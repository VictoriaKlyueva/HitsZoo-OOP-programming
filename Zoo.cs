using System;
using System.Collections.Generic;
using System.Linq;

namespace HitsZoo
{
    public class Zoo : IAddEnclouser, IChangeSection
    {
        public int currentAnimalId = 0;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;
        private int currentEnclouserId = 0;

        public int AnimalsCount { get; set; } = 0;
        public int VisitorsCount { get; set; } = 0;
        public int StaffCount { get; set; } = 0;
        public int EnclousersCount { get; set; } = 0;
        private Random random = new Random();


        private List<IEntity> entities = new List<IEntity>();


        public void AddEntity(IEntity entity)
        {
            entities.Add(entity);
        }

        public List<IEntity> GetEntitiesByType<T>()
        {
            return entities.Where(e => e.GetType() == typeof(T)).ToList();
        }

        public IEntity GetEntityById(Guid entityId)
        {
            return entities.FirstOrDefault(e => e.Id2 == entityId);
        }

        public void RemoveEntity(Guid entityId)
        {
            IEntity entity = entities.FirstOrDefault(e => e.Id2 == entityId);
            if (entity != null)
            {
                entities.Remove(entity);
            }
        }

        private void GenerateAnimals(int animalsNumber)
        {
            Random rnd = new Random();
            Horse horse = new Horse(currentAnimalId, "Я дефолтная лошадь", 0);
            AddAnimal(horse, true);
            AddEntity(new Enclouser(currentEnclouserId, horse));
            AddEntity(horse);

            Capybara capybara = new Capybara(currentAnimalId, "Я дефолтная капибара", 1);
            AddAnimal(capybara, true);
            AddEntity(new Enclouser(currentEnclouserId, capybara));
            AddEntity(capybara);

            Bars bars = new Bars(currentAnimalId, "Я дефолтный барс", 2);
            AddAnimal(bars, true);
            AddEntity(new Enclouser(currentEnclouserId, bars));
            AddEntity(bars);

            for (int i = 3; i < animalsNumber; i++)
            {
                int animalChoice = rnd.Next(0, 3);

                if (animalChoice == 0)
                {
                    Horse newHorse = new Horse(currentAnimalId, "Я дефолтная лошадь", 0);
                    AddAnimal(newHorse, false);
                    AddEntity(newHorse);
                }
                else if (animalChoice == 1)
                {
                    Capybara newCapybara = new Capybara(currentAnimalId, "Я дефолтная капибара", 1);
                    AddAnimal(newCapybara, false);
                    AddEntity(newCapybara);
                }
                else
                {
                    Bars newBars = new Bars(currentAnimalId, "Я дефолтный барс", 2);
                    AddAnimal(newBars, false);
                    AddEntity(newBars);
                }
            }
        }

        public void AddEnclouser(Animal animal)
        {
            Enclouser enclouser = new Enclouser(currentEnclouserId, animal);
            currentEnclouserId++;
            EnclousersCount++;
        }

        public void AddAnimal(Horse horse, bool newEnclouser)
        {
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(horse);
            }
            else
            {
                FindEnclouserById(horse.EnclouserId).AddAnimal(horse);
            }
        }

        public void AddAnimal(Capybara capybara, bool newEnclouser)
        {
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(capybara);
            }
            else
            {
                FindEnclouserById(capybara.EnclouserId).AddAnimal(capybara);
            }
        }

        public void AddAnimal(Bars bars, bool newEnclouser)
        {
            currentAnimalId++;
            AnimalsCount++;

            if (newEnclouser)
            {
                AddEnclouser(bars);
            }
            else
            {
                FindEnclouserById(bars.EnclouserId).AddAnimal(bars);
            }
        }

        public Enclouser FindEnclouserById(int id)
        {
            List<IEntity> enclousers = GetEntitiesByType<Enclouser>();
            enclousers.FirstOrDefault(enclouser => enclouser.Id == id);

            return null;
        }

        public void RemoveAnimalFromEnclouser(Animal animal, Enclouser enclouser)
        {
            enclouser.RemoveAnimal(animal);
        }

        private int AssignAnimal()
        {
            List<IEntity> animals = GetEntitiesByType<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal.IsFree)
                {
                    animal.IsFree = false;
                    return animal.Id;
                }
            }
            return -1;
        }

        public void ChangeSection(
            Animal animal,
            IOpenSection openEnclouser,
            IClosedSection closedEnclouser
        )
        {
            // Животное в открытой части
            if (openEnclouser.OpenAnimals.Contains(animal))
            {
                openEnclouser.OpenAnimals.Remove(animal);
                closedEnclouser.ClosedAnimals.Add(animal);
            }
            // Животное в закрытой части
            else
            {
                closedEnclouser.ClosedAnimals.Remove(animal);
                openEnclouser.OpenAnimals.Add(animal);
            }
        }

        private void UpdateAnimals()
        {
            List<IEntity> animals = GetEntitiesByType<Animal>();
            for (int i = 0; i < AnimalsCount; i++)
            {
                Animal animal = (Animal)animals[i];
                Enclouser currentEnclouser = FindEnclouserById(animal.EnclouserId);

                // Обновление количества еды
                if (animal.IsHungry && !currentEnclouser.IsFoodEmpty())
                {
                    animal.Eat();
                    currentEnclouser.Feed();
                }

                animal.Update();

                // Обновление статуса вольера, если его закрепили или открепили
                bool found = false;
                List<IEntity> staffs = GetEntitiesByType<Staff>();
                for (int j = 0; j < StaffCount; j++)
                {
                    Staff staff = (Staff)staffs[i];
                    if (staff.wardEnclouserId == animals[i].Id)
                    {
                        animal.IsFree = false;
                        found = true;
                    }
                }
                if (!found)
                {
                    animal.IsFree = true;
                }

                // Перемещение животного в другую часть вольера
                if (random.NextDouble() < 0.01)
                {
                    ChangeSection(
                        animal,
                        FindEnclouserById(animal.EnclouserId),
                        FindEnclouserById(animal.EnclouserId)
                    );
                }
            }
        }

        private void UpdateVisitors(double probaility)
        {
            List<IEntity> visitors = GetEntitiesByType<Visitor>();   
            for (int i = 0; i < VisitorsCount; i++)
            {
                Visitor visitor = (Visitor)visitors[i];
                // Покупка еды
                if (random.NextDouble() < probaility)
                {
                    visitor.BuyFood();
                }

                // Кормление животного
                if (random.NextDouble() < probaility)
                {
                    visitor.FeedAnimal(GetRandomEnclouser());
                }
            }
        }

        private void UpdateStaff()
        {
            List<IEntity> staffs = GetEntitiesByType<Staff>();
            for (int i = 0; i < staffs.Count; i++)
            {
                Staff staff = (Staff)staffs[i];
                staffs[i].Update(FindEnclouserById(staff.wardEnclouserId));
            }
        }

        public void Update()
        {
            UpdateAnimals();
            UpdateStaff();
            UpdateVisitors(0.1);
        }

        public Animal FindAnimalById(int id)
        {
            List<IEntity> animals = GetEntitiesByType<Animal>();
            return (Animal)animals.FirstOrDefault(animal => animal.Id == id);
        }

        public Visitor FindVisitorById(int id)
        {
            List<IEntity> visitors = GetEntitiesByType<Visitor>();
            return (Visitor)visitors.FirstOrDefault(visitor => visitor.Id == id);
        }

        public Staff FindStaffById(int id)
        {
            List<IEntity> staffs = GetEntitiesByType<Staff>();
            return (Staff)staffs.FirstOrDefault(staff => staff.Id == id);
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            textBox.Text += "Казахские кони:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> horses = GetEntitiesByType<Horse> ();
            for (int i = 0; i < horses.Count; i++)
            {
                textBox.Text += horses[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
            textBox.AppendText(Environment.NewLine);

            textBox.Text += "Балдёжные капибары:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> capybaras = GetEntitiesByType<Capybara>();
            for (int i = 0; i < capybaras.Count; i++)
            {
                textBox.Text += capybaras[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
            textBox.AppendText(Environment.NewLine);

            textBox.Text += "Кыргызские барсы:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> barses = GetEntitiesByType<Bars>();
            for (int i = 0; i < barses.Count; i++)
            {
                textBox.Text += barses[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
            textBox.AppendText(Environment.NewLine);
        }

        private void PrintPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            textBox.Text += "Сотрудники: ";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> staffs = GetEntitiesByType<Staff>();
            for (int i = 0; i < staffs.Count; i++)
            {
                textBox.Text += staffs[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            textBox.Text += "Посетители: ";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> visitors = GetEntitiesByType<Visitor>();
            for (int i = 0; i < visitors.Count; i++)
            {
                textBox.Text += visitors[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintEnclousers(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            List<IEntity> enclousers = GetEntitiesByType<Enclouser>();
            for (int i = 0; i < enclousers.Count; i++)
            {
                textBox.Text += enclousers[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons,
                          System.Windows.Forms.TextBox textBoxEnclousers)
        {
            textBoxZoo.Text = $"Животных: {AnimalsCount}   Работников: {StaffCount}   Посетителей: {VisitorsCount}   Вольеров: {EnclousersCount}";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
            PrintEnclousers(textBoxEnclousers);
        }

        private Enclouser GetRandomEnclouser()
        {
            int choice = random.Next(0, EnclousersCount - 1);
            return (Enclouser)GetEntitiesByType<Enclouser>()[choice];
        }

        public Zoo ()
        {
            GenerateAnimals(15);
        }
    }
}

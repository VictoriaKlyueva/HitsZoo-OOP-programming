using System;
using System.Collections.Generic;
using System.Linq;

namespace HitsZoo
{
    public class Zoo : IChangeSection
    {
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
            int currentAnimalId = 0;
            int currentEnclouserId = 0;
            Random rnd = new Random();

            // Первые 3 типа животных в первых трех вольерах
            Horse horse = new Horse(currentAnimalId, "Я дефолтная лошадь", 0);
            AddEntity(new Enclouser(currentEnclouserId, horse));
            AddEntity(horse);
            currentAnimalId++;
            currentEnclouserId++;

            Capybara capybara = new Capybara(currentAnimalId, "Я дефолтная капибара", 1);
            AddEntity(new Enclouser(currentEnclouserId, capybara));
            AddEntity(capybara);
            currentAnimalId++;
            currentEnclouserId++;

            Bars bars = new Bars(currentAnimalId, "Я дефолтный барс", 2);
            AddEntity(new Enclouser(currentEnclouserId, bars));
            AddEntity(bars);
            currentAnimalId++;

            for (int i = 3; i < animalsNumber; i++)
            {
                int animalChoice = rnd.Next(0, 3);

                if (animalChoice == 0)
                {
                    Horse newHorse = new Horse(currentAnimalId, "Я дефолтная лошадь", 0);
                    AddEntity(newHorse);
                    currentAnimalId++;
                }
                else if (animalChoice == 1)
                {
                    Capybara newCapybara = new Capybara(currentAnimalId, "Я дефолтная капибара", 1);
                    AddEntity(newCapybara);
                    currentAnimalId++;
                }
                else
                {
                    Bars newBars = new Bars(currentAnimalId, "Я дефолтный барс", 2);
                    AddEntity(newBars);
                    currentAnimalId++;
                }
            }
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
            List<IEntity> animals = getAnimals();
            for (int i = 0; i < animals.Count; i++)
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
                for (int j = 0; j < staffs.Count; j++)
                {
                    Staff staff = (Staff)staffs[j];
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
            for (int i = 0; i < visitors.Count; i++)
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

        private List<IEntity> getAnimals()
        {
            List<IEntity> horse = GetEntitiesByType<Horse>();
            List<IEntity> capybara = GetEntitiesByType<Capybara>();
            List<IEntity> bars = GetEntitiesByType<Bars>();

            return (horse.Concat(capybara)).Concat(bars).ToList();
        }

        public Animal FindAnimalById(int id)
        {
            return (Animal)getAnimals().FirstOrDefault(animal => animal.Id == id);
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

        public Enclouser FindEnclouserById(int id)
        {
            List<IEntity> enclousers = GetEntitiesByType<Enclouser>();
            return (Enclouser)enclousers.FirstOrDefault(enclouser => enclouser.Id == id);
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

            textBoxZoo.Text = $"Животных: { GetEntitiesByType<Horse>().Count + GetEntitiesByType<Capybara>().Count + GetEntitiesByType<Bars>().Count }   " +
                $"Работников: { GetEntitiesByType<Staff>().Count }   " +
                $"Посетителей: {GetEntitiesByType<Visitor>().Count }   " +
                $"Вольеров: {GetEntitiesByType<Enclouser>().Count }";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
            PrintEnclousers(textBoxEnclousers);
        }

        private Enclouser GetRandomEnclouser()
        {
            List<IEntity> enclousers = GetEntitiesByType<Enclouser>();
            int choice = random.Next(0, enclousers.Count - 1);
            return (Enclouser)enclousers[choice];
        }

        public Zoo ()
        {
            GenerateAnimals(15);
        }
    }
}

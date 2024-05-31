using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public List<IEntity> FindEntitiesByType<T>()
        {
            return entities.Where(e => e.GetType() == typeof(T)).ToList();
        }

        public IEntity FindEntityById(Guid entityId)
        {
            return entities.FirstOrDefault(e => e.Id == entityId);
        }

        public void RemoveEntity(Guid entityId)
        {
            IEntity entity = entities.FirstOrDefault(e => e.Id == entityId);
            if (entity != null)
            {
                entities.Remove(entity);
            }

            try
            {
                Horse testHorse = (Horse)entity;
                MessageBox.Show("Ксюша съела коня!!!!!!");
            }
            catch {}
        }

        public Guid GetEmptyEnclouserId()
        {
            Enclouser enclouser = (Enclouser)FindEntitiesByType<Enclouser>().FirstOrDefault(e => !((Enclouser)e).IsLinked);
            enclouser.ChangeLinkStatus();
            return enclouser.Id;
        }

        private void GenerateAnimals(int animalsNumber)
        {
            // Генерация Guid для трех новых вольеров
            Guid firstGuid = Guid.NewGuid();
            Guid secondGuid = Guid.NewGuid();
            Guid thirdGuid = Guid.NewGuid();

            // Первые 3 типа животных в первых трех вольерах
            Horse horse = new Horse("Я дефолтная лошадь", firstGuid);
            AddEntity(new Enclouser(horse, firstGuid));
            AddEntity(horse);

            Capybara capybara = new Capybara("Я дефолтная капибара", secondGuid);
            AddEntity(new Enclouser(capybara, secondGuid));
            AddEntity(capybara);

            Bars bars = new Bars("Я дефолтный барс", thirdGuid);
            AddEntity(new Enclouser(bars, thirdGuid));
            AddEntity(bars);

            for (int i = 3; i < animalsNumber; i++)
            {
                int animalChoice = random.Next(0, 3);

                if (animalChoice == 0)
                {
                    Horse newHorse = new Horse("Я дефолтная лошадь", firstGuid);
                    AddEntity(newHorse);
                }
                else if (animalChoice == 1)
                {
                    Capybara newCapybara = new Capybara("Я дефолтная капибара", secondGuid);
                    AddEntity(newCapybara);
                }
                else
                {
                    Bars newBars = new Bars("Я дефолтный барс", thirdGuid);
                    AddEntity(newBars);
                }
            }
        }

        public void RemoveAnimalFromEnclouser(Animal animal, Enclouser enclouser)
        {
            enclouser.RemoveAnimal(animal);
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
            List<IEntity> animals = GetAnimals();
            for (int i = 0; i < animals.Count; i++)
            {
                Animal animal = (Animal)animals[i];
                Enclouser currentEnclouser = (Enclouser)FindEntityById(animal.EnclouserId);

                // Обновление количества еды
                if (animal.IsHungry && !currentEnclouser.IsFoodEmpty())
                {
                    // Выбор марки корма
                    int index = random.Next(0, 2);
                    if (index == 0)
                    {
                        animal.Eat<Whiskas>();
                        currentEnclouser.Feed();
                    }
                    else if (index == 1)
                    {
                        animal.Eat<Kitekat>();
                        currentEnclouser.Feed();
                    }
                    else
                    {
                        animal.Eat<Pedigree>();
                        currentEnclouser.Feed();
                    }
                }

                animal.Update();

                // Обновление статуса вольера, если его закрепили или открепили
                bool found = false;
                List<IEntity> staffs = FindEntitiesByType<Staff>();
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
                        (Enclouser)FindEntityById(animal.EnclouserId),
                        (Enclouser)FindEntityById(animal.EnclouserId)
                    );
                }
            }
        }

        private void UpdateVisitors(double probaility)
        {
            List<IEntity> visitors = FindEntitiesByType<Visitor>();   
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
            List<IEntity> staffs = FindEntitiesByType<Staff>();
            for (int i = 0; i < staffs.Count; i++)
            {
                Staff staff = (Staff)staffs[i];
                staffs[i].Update(FindEntityById(staff.wardEnclouserId));
            }
        }

        private void UpdateEnclousers()
        {
            List<IEntity> enclousers = FindEntitiesByType<Enclouser>();
            for (int i = 0; i < enclousers.Count; i++)
            {
                Enclouser enclouser = (Enclouser)enclousers[i];
                enclousers[i].Update(enclouser);
            }
        }

        public void Update()
        {
            UpdateAnimals();
            UpdateStaff();
            UpdateVisitors(0.1);
            UpdateEnclousers();
        }

        private List<IEntity> GetAnimals()
        {
            List<IEntity> horse = FindEntitiesByType<Horse>();
            List<IEntity> capybara = FindEntitiesByType<Capybara>();
            List<IEntity> bars = FindEntitiesByType<Bars>();

            List<IEntity> animals = horse.Concat(capybara).Concat(bars).ToList();
            animals.Sort((a, b) => string.Compare(a.Id.ToString(), b.Id.ToString()));

            return animals;
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            textBox.Text += "Казахские кони:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> horses = FindEntitiesByType<Horse>();
            horses.Sort((a, b) => string.Compare(a.Id.ToString(), b.Id.ToString()));
            for (int i = 0; i < horses.Count; i++)
            {
                textBox.Text += horses[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
            textBox.AppendText(Environment.NewLine);

            textBox.Text += "Балдёжные капибары:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> capybaras = FindEntitiesByType<Capybara>();
            capybaras.Sort((a, b) => string.Compare(a.Id.ToString(), b.Id.ToString()));
            for (int i = 0; i < capybaras.Count; i++)
            {
                textBox.Text += capybaras[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
            textBox.AppendText(Environment.NewLine);

            textBox.Text += "Кыргызские барсы:";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> barses = FindEntitiesByType<Bars>();
            barses.Sort((a, b) => string.Compare(a.Id.ToString(), b.Id.ToString()));
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
            List<IEntity> staffs = FindEntitiesByType<Staff>();
            for (int i = 0; i < staffs.Count; i++)
            {
                textBox.Text += staffs[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            textBox.Text += "Посетители: ";
            textBox.AppendText(Environment.NewLine);
            List<IEntity> visitors = FindEntitiesByType<Visitor>();
            for (int i = 0; i < visitors.Count; i++)
            {
                textBox.Text += visitors[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintEnclousers(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            List<IEntity> enclousers = FindEntitiesByType<Enclouser>();
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

            textBoxZoo.Text = $"Животных: { FindEntitiesByType<Horse>().Count + FindEntitiesByType<Capybara>().Count + FindEntitiesByType<Bars>().Count }   " +
                $"Работников: { FindEntitiesByType<Staff>().Count }   " +
                $"Посетителей: {FindEntitiesByType<Visitor>().Count }   " +
                $"Вольеров: {FindEntitiesByType<Enclouser>().Count }";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
            PrintEnclousers(textBoxEnclousers);
        }

        private Enclouser GetRandomEnclouser()
        {
            List<IEntity> enclousers = FindEntitiesByType<Enclouser>();
            int choice = random.Next(0, enclousers.Count - 1);
            return (Enclouser)enclousers[choice];
        }

        public Zoo ()
        {
            GenerateAnimals(15);
        }
    }
}

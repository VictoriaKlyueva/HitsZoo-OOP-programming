﻿using System;
using System.Linq;

namespace HitsZoo
{
    public class Zoo : IAddEnclouser, IChangeSection
    {
        private Animal[] animalsArray = new Animal[100];
        private Visitor[] visitorsArray = new Visitor[100];
        private Staff[] staffArray = new Staff[100];
        private Enclouser<Animal>[] enclousersArray = new Enclouser<Animal>[100];

        public int currentAnimalId = 0;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;
        private int currentEnclouserId = 0;

        public int AnimalsCount { get; set; } = 0;
        public int VisitorsCount { get; set; } = 0;
        public int StaffCount { get; set; } = 0;
        public int EnclousersCount { get; set; } = 0;

        private Random random = new Random();
             
        private void GenerateAnimals(int enclousersNumber, int animalsNumber)
        {
            Random rnd = new Random();
            for (int i = 0; i < animalsNumber; i++)
            {
                int animalChoice = rnd.Next(0, 3);
                int enclouserId = i < enclousersNumber ? i : rnd.Next(0, enclousersNumber);

                if (animalChoice == 0)
                {
                    AddAnimal(new Horse(currentAnimalId, "Я дефолтная лошадь",
                              enclouserId), i < enclousersNumber);
                }
                else if (animalChoice == 1)
                {
                    AddAnimal(new Capybara(currentAnimalId, "Я дефолтная капибара",
                              enclouserId), i < enclousersNumber);
                }
                else
                {
                    AddAnimal(new Bars(currentAnimalId, "Я дефолтный барс",
                              enclouserId), i < enclousersNumber);
                }
            }
        }

        public void AddEnclouser(Horse animal)
        {
            Enclouser<Horse> enclouser = new Enclouser<Horse>(currentEnclouserId, animal);
            enclousersArray[EnclousersCount] = enclouser;
            currentEnclouserId++;
            EnclousersCount++;
        }

        public void AddEnclouser(Capybara animal)
        {
            Enclouser<Capybara> enclouser = new Enclouser<Capybara>(currentEnclouserId, animal);
            enclousersArray[EnclousersCount] = enclouser;
            currentEnclouserId++;
            EnclousersCount++;
        }

        public void AddEnclouser(Bars animal)
        {
            Enclouser<Bars> enclouser = new Enclouser<Bars>(currentEnclouserId, animal);
            enclousersArray[EnclousersCount] = enclouser;
            currentEnclouserId++;
            EnclousersCount++;
        }

        public Enclouser<Animal> FindEnclouserById(int id)
        {
            for (int i = 0; i < EnclousersCount; i++)
            {
                if (enclousersArray[i].Id == id)
                {
                    return enclousersArray[i];
                }
            }

            return null;
        }

        public void AddAnimal(Horse horse, bool newEnclouser)
        {
            animalsArray[AnimalsCount] = horse;
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
            animalsArray[AnimalsCount] = capybara;
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
            animalsArray[AnimalsCount] = bars;
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

        public void RemoveAnimal(Animal animalForRemoving)
        {
            animalsArray = animalsArray.Where(val => val != animalForRemoving).ToArray();
            AnimalsCount--;
        }

        public void RemoveAnimalFromEnclouser(Animal animal, IEnclouser<Animal> enclouser)
        {
            enclouser.RemoveAnimal(animal);
        }

        public void AddVisitor(string name, int age)
        {
            Visitor visitor = new Visitor(currentVisitorId, name, age);
            visitorsArray[VisitorsCount] = visitor;
            currentVisitorId++;
            VisitorsCount++;
        }
        public void RemoveVisitor(Person visitorForRemoving)
        {
            visitorsArray = visitorsArray.Where(val => val != visitorForRemoving).ToArray();
            VisitorsCount--;
        }

        public void AddStaff(string name, int age, string occupation)
        {
            Staff staff = new Staff(currentStaffId, name, age, occupation, AssignAnimal());
            staffArray[StaffCount] = staff;
            currentStaffId++;
            StaffCount++;
        }

        public void RemoveStaff(Staff staffForRemoving)
        {
            staffArray = staffArray.Where(val => val != staffForRemoving).ToArray();
            StaffCount--;
        }

        private int AssignAnimal()
        {
            foreach (Animal animal in animalsArray)
            {
                if (animal == null) return -1;
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
                IOpenSection<Animal> openEnclouser,
                IClosedSection<Animal> closedEnclouser
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
            for (int i = 0; i < AnimalsCount; i++)
            {
                Enclouser<Animal> currentEnclouser = FindEnclouserById(animalsArray[i].EnclouserId);

                // Обновление количества еды
                if (animalsArray[i].IsHungry && !currentEnclouser.IsFoodEmpty())
                {
                    animalsArray[i].Eat();
                    currentEnclouser.Feed();
                }

                animalsArray[i].Update();

                // Обновление статуса вольера, если его закрепили или открепили
                bool found = false;
                for (int j = 0; j < StaffCount; j++)
                {
                    if (staffArray[j].wardEnclouserId == animalsArray[i].Id)
                    {
                        animalsArray[i].IsFree = false;
                        found = true;
                    }
                }
                if (!found)
                {
                    animalsArray[i].IsFree = true;
                }

                // Перемещение животного в другую часть вольера
                if (random.NextDouble() < 0.01)
                {
                    ChangeSection(
                        animalsArray[i],
                        FindEnclouserById(animalsArray[i].EnclouserId),
                        FindEnclouserById(animalsArray[i].EnclouserId)
                    );
                }
            }
        }

        private void UpdateVisitors(double probaility)
        {
            for (int i = 0; i < VisitorsCount; i++)
            {
                // Покупка еды
                if (random.NextDouble() < probaility)
                {
                    visitorsArray[i].BuyFood();
                }

                // Кормление животного
                if (random.NextDouble() < probaility)
                {
                    visitorsArray[i].FeedAnimal(GetRandomEnclouser());
                }
            }
        }

        private void UpdateStaff()
        {
            for (int i = 0; i < StaffCount; i++)
            {   
                if (staffArray[i].wardEnclouserId != -1)
                {
                    staffArray[i].Update(FindEnclouserById(staffArray[i].wardEnclouserId));
                }
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
            for (int i = 0; i < AnimalsCount; i++)
            {
                if (animalsArray[i].Id == id) return animalsArray[i];
            }
            return null;
        }

        public Person FindVisitorById(int id)
        {
            for (int i = 0; i < VisitorsCount; i++)
            {
                if (visitorsArray[i].Id == id) return visitorsArray[i];
            }
            return null;
        }

        public Staff FindStaffById(int id)
        {
            for (int i = 0; i < StaffCount; i++)
            {
                if (staffArray[i].Id == id) return staffArray[i];
            }
            return null;
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < AnimalsCount; i++)
            {
                textBox.Text += animalsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < StaffCount; i++)
            {
                textBox.Text += staffArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            for (int i = 0; i < VisitorsCount; i++)
            {
                textBox.Text += visitorsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintEnclousers(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < EnclousersCount; i++)
            {
                textBox.Text += enclousersArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons,
                          System.Windows.Forms.TextBox textBoxEnclousers)
        {
            textBoxZoo.Text = $"Животных: {AnimalsCount}   Работников: {StaffCount}   Посетителей: {VisitorsCount}   ";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
            PrintEnclousers(textBoxEnclousers);
        }

        private Enclouser<Animal> GetRandomEnclouser()
        {
            int choice = random.Next(0, EnclousersCount - 1);
            return enclousersArray[choice];
        }

        public Zoo ()
        {
            GenerateAnimals(3, 15);
        }
    }
}

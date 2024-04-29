using System;
using System.Deployment.Application;
using System.Linq;

namespace HitsZoo
{
    public class Zoo
    {
        private Animal[] animalsArray = new Animal[100];
        private Person[] visitorsArray = new Person[100];
        private Staff[] staffArray = new Staff[100];

        private int currentAnimalId = 0;
        private int currentStaffId = 0;
        private int currentVisitorId = 0;

        public int AnimalsCount { get; set; } = 0;
        public int VisitorsCount { get; set; } = 0;
        public int StaffCount { get; set; } = 0;

        public void AddHorse(string voice)
        {
            Horse horse = new Horse(currentAnimalId, voice);
            animalsArray[AnimalsCount] = horse;
            currentAnimalId++;
            AnimalsCount++;
        }

        public void AddCapybara(string voice)
        {
            Capybara capybara = new Capybara(currentAnimalId, voice);
            animalsArray[AnimalsCount] = capybara;
            currentAnimalId++;
            AnimalsCount++;
        }

        public void AddBars(string voice)
        {
            Bars bars = new Bars(currentAnimalId, voice);
            animalsArray[AnimalsCount] = bars;
            currentAnimalId++;
            AnimalsCount++;
        }

        public void RemoveAnimal(Animal animalForRemoving)
        {
            animalsArray = animalsArray.Where(val => val != animalForRemoving).ToArray();
            AnimalsCount--;
        }

        public void AddVisitor(string name, int age)
        {
            Person visitor = new Person(currentVisitorId, name, age);
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

        private void UpdateAnimals()
        {
            for (int i = 0; i < AnimalsCount; i++)
            {
                animalsArray[i].Update();

                // Обновление статуса животного, если его закрепили или открепили
                bool found = false;
                for (int j = 0; j < StaffCount; j++)
                {
                    if (staffArray[j].wardAnimalId == animalsArray[i].Id)
                    {
                        animalsArray[i].IsFree = false;
                        found = true;
                    }
                }
                if (!found)
                {
                    animalsArray[i].IsFree = true;
                }
            }
        }

        private void UpdateStaff()
        {
            for (int i = 0; i < StaffCount; i++)
            {   
                if (staffArray[i].wardAnimalId != -1)
                {
                    staffArray[i].Update(FindAnimalById(staffArray[i].wardAnimalId));
                }
            }
        }

        public void Update()
        {
            UpdateAnimals();
            UpdateStaff();
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
                if (visitorsArray[i].id == id) return visitorsArray[i];
            }
            return null;
        }

        public Staff FindStaffById(int id)
        {
            for (int i = 0; i < StaffCount; i++)
            {
                if (staffArray[i].id == id) return staffArray[i];
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

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons)
        {
            textBoxZoo.Text = $"Животных: {AnimalsCount}   Работников: {StaffCount}   Посетителей: {VisitorsCount}   ";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
        }
    }
}

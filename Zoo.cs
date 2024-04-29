using System;
using System.Linq;

namespace HitsZoo
{
    public class Zoo
    {
        public int animalsCount = 0;
        Animal[] animalsArray = new Animal[100];
        public int visitorsCount = 0;
        Person[] visitorsArray = new Person[100];
        public int staffCount = 0;
        Staff[] staffArray = new Staff[100];

        public void AddAnimal(Animal animal)
        {
            animalsArray[animalsCount] = animal;
            animalsCount++;
        }

        public void RemoveAnimal(Animal animalForRemoving)
        {
            animalsArray = animalsArray.Where(val => val != animalForRemoving).ToArray();
            animalsCount--;
        }

        public void RemoveVisitor(Person visitorForRemoving)
        {
            visitorsArray = visitorsArray.Where(val => val != visitorForRemoving).ToArray();
            visitorsCount--;
        }

        public void RemoveStaff(Staff staffForRemoving)
        {
            staffArray = staffArray.Where(val => val != staffForRemoving).ToArray();
            staffCount--;
        }

        public void AddVisitor(Person visitor)
        {
            visitorsArray[visitorsCount] = visitor;
            visitorsCount++;
        }

        public void AddStaff(Staff staff)
        {
            staffArray[staffCount] = staff;
            staffCount++;
        }

        public void UpdateAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                animalsArray[i].currentHunger += 1;
                animalsArray[i].Update();
            }
        }

        public Animal FindAnimalById(int id)
        {
            for (int i = 0; i < animalsCount; i++)
            {
                if (animalsArray[i].id == id) return animalsArray[i];
            }
            return null;
        }

        public Person FindVisitorById(int id)
        {
            for (int i = 0; i < visitorsCount; i++)
            {
                if (visitorsArray[i].id == id) return visitorsArray[i];
            }
            return null;
        }

        public Staff FindStaffById(int id)
        {
            for (int i = 0; i < staffCount; i++)
            {
                if (staffArray[i].id == id) return staffArray[i];
            }
            return null;
        }

        private void PrintAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < animalsCount; i++)
            {
                textBox.Text += animalsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        private void PrintPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < staffCount; i++)
            {
                textBox.Text += staffArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }

            for (int i = 0; i < visitorsCount; i++)
            {
                textBox.Text += visitorsArray[i].Print();
                textBox.AppendText(Environment.NewLine);
            }
        }

        public void PrintStatus(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons)
        {
            textBoxZoo.Text = $"Животных: {animalsCount} Работников: {staffCount} Посетителей: {visitorsCount} ";

            PrintAnimals(textBoxAnimals);
            PrintPersons(textBoxPersons);
        }
    }
}

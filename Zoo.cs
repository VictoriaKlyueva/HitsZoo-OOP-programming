using System;

namespace HitsZoo
{
    public class Zoo
    {
        public int animalsCount = 0;
        Animal[] animalsArray = new Animal[100];
        public int personsCount = 0;
        Person[] personsArray = new Person[100];
        public int staffCount = 0;

        public void addAnimal(Animal animal)
        {
            animalsArray[animalsCount] = animal;
            animalsCount++;
        }

        public void addPerson(Person person)
        {
            personsArray[personsCount] = person;
            if (person.type == "Работник")
            {
                staffCount++;
            }
            personsCount++;
        }

        public void updateAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                animalsArray[i].currentHunger += 1;
                animalsArray[i].update();
            }
        }

        private void printAnimals(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < animalsCount; i++)
            {
                textBox.Text += animalsArray[i].print();
                textBox.AppendText(Environment.NewLine);
                Console.WriteLine($"Номер: {i}");
            }
        }

        private void printPersons(System.Windows.Forms.TextBox textBox)
        {
            textBox.Text = "";
            for (int i = 0; i < personsCount; i++)
            {
                textBox.Text += personsArray[i].print();
                textBox.AppendText(Environment.NewLine);
                Console.WriteLine($"Номер: {i}");
            }
        }

        public void print(System.Windows.Forms.TextBox textBoxZoo,
                          System.Windows.Forms.TextBox textBoxAnimals,
                          System.Windows.Forms.TextBox textBoxPersons)
        {
            textBoxZoo.Text = $"Животных: {animalsCount} Работников: {staffCount} Посетителей: {personsCount - staffCount} ";

            printAnimals(textBoxAnimals);
            printPersons(textBoxPersons);
        }
    }
}

using System;

namespace HitsZoo
{
    public class Zoo
    {
        public int animalsCount = 0;
        Animal[] animalsArray = new Animal[100];
        public int personsCount = 0;
        Person[] personsArray = new Person[100];

        public void addAnimal(Animal animal)
        {
            animalsArray[animalsCount] = animal;
            animalsCount++;
        }

        public void addPerson(Person human)
        {
            personsArray[personsCount] = human;
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

        public void printAnimals()
        {
            for (int i = 0; i < animalsCount; i++)
            {
                Console.WriteLine($"Номер: {i}");
                animalsArray[i].print();
            }
        }

        public void printPersons()
        {
            for (int i = 0; i < personsCount; i++)
            {
                Console.WriteLine($"Номер: {i}");
                personsArray[i].print();
            }
        }
    }
}

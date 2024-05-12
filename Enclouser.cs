using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public class Enclouser: IEnclouser, IFood, IOpenEnclouser, IClosedEnclouser
    {
        public int Id { get; set; }
        public int Food { get; set; }

        private List<Animal> closedAnimals = new List<Animal>();
        public List<Animal> ClosedAnimals { get => closedAnimals; set => closedAnimals = value; }

        private List<Animal> openAnimals = new List<Animal>();
        public List<Animal> OpenAnimals { get => openAnimals; set => openAnimals = value; }

        private List<Animal> animals = new List<Animal>();
        public List<Animal> Animals { get => animals; set => animals = value; }

        private int size;

        public void Feed()
        {
            Food -= 1;
        }

        public bool IsFoodEmpty()
        {
            return Food == 0;
        }

        public void UpdateFood(int food)
        {
            Food = food;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            ClosedAnimals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public string Print()
        {
            string result = $"ID: {Id} Animals: ";
            for (int i = 0; i < animals.Count; i++)
            {
                result += animals[i].Id.ToString() + " ";
            }

            result += "Открытая часть: ";

            for (int i = 0; i < OpenAnimals.Count; i++)
            {
                result += OpenAnimals[i].Id.ToString() + " ";
            }

            result += "Закрытая часть: ";

            for (int i = 0; i < ClosedAnimals.Count; i++)
            {
                result += ClosedAnimals[i].Id.ToString() + " ";
            }

            return result + $"Еды: {Food} \n";
        }

        public Enclouser(int id, Animal animal) 
        {
            Id = id;
            animals.Add(animal);
            Food = 0;
        }
    }
}
using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public class Enclouser<T> : IEnclouser<T>, IFood where T : Animal
    {
        public int Id { get; set; }
        public int Food { get; set; }

        private List<T> closedAnimals = new List<T>();
        public List<T> ClosedAnimals { get => closedAnimals; set => closedAnimals = value; }

        private List<T> openAnimals = new List<T>();
        public List<T> OpenAnimals { get => openAnimals; set => openAnimals = value; }

        private List<T> animals = new List<T>();
        public List<T> Animals { get => animals; set => animals = value; }

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

        public void AddAnimal(T animal)
        {   
            try
            {
                Animals.Add(animal);
                ClosedAnimals.Add(animal);
            }
            catch
            {
                Console.WriteLine("Неверный тип животного!");
            }
        }

        public void RemoveAnimal(T animal)
        {
            Animals.Remove(animal);
            if (ClosedAnimals.Contains(animal))
            {
                ClosedAnimals.Remove(animal);
            }
            else
            {
                OpenAnimals.Remove(animal);
            }
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

            return result + $"Еды: {Food} Тип: {typeof(T)} \n";
        }

        public Enclouser(int id, T animal) 
        {
            Id = id;
            Animals.Add(animal);
            Food = 0;

            if(typeof(T) == typeof(Horse))
            {
                size = 5;
            }
            else if (typeof(T) == typeof(Bars))
            {
                size = 10;
            }
            else
            {
                size = 15;
            }
        }

        // Неявные операторы преобразования из любого дочернего класса Animal
        // к классу Animal для испоьзования в generic
        
        /*
        public static implicit operator Enclouser<T>(Enclouser<Horse> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Enclouser<T>(Enclouser<Capybara> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Enclouser<T>(Enclouser<Bars> v)
        {
            throw new NotImplementedException();
        }
        */
    }
}
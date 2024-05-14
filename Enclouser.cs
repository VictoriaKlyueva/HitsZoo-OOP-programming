using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HitsZoo
{
    public class Enclouser: IEnclouser, IFood
    {
        public int Id { get; set; }
        public int Food { get; set; }

        private List<Animal> closedAnimals = new List<Animal>();
        public List<Animal> ClosedAnimals { get => closedAnimals; set => closedAnimals = value; }

        private List<Animal> openAnimals = new List<Animal>();
        public List<Animal> OpenAnimals { get => openAnimals; set => openAnimals = value; }

        private List<Animal> animals = new List<Animal>();
        public List<Animal> Animals { get => animals; set => animals = value; }

        private int size = -1;

        public bool IsFull()
        {
            return animals.Count == size;
        }

        public Type GetAnimalsType()
        {
            if (animals.Count == 0)
                return null;
            else if (animals[0].GetType() == typeof(Horse))
            {
                return typeof(Horse);
            }
            else if (animals[0].GetType() == typeof(Capybara))
            {
                return typeof(Capybara);
            }
            else
            {
                return typeof(Bars);
            }
        }

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

        public void AddAnimal(Horse animal)
        {
            if (animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Horse) || GetAnimalsType() == null)
            {
                animals.Add(animal);
                ClosedAnimals.Add(animal);
                SetSize();
            }
            else
            {
                MessageBox.Show("Неверный тип животного");
            }
        }

        public void AddAnimal(Capybara animal)
        {
            if (animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Capybara) || GetAnimalsType() == null)
            {
                animals.Add(animal);
                ClosedAnimals.Add(animal);
                SetSize();
            }
            else
            {
                MessageBox.Show("Неверный тип животного");
            }
        }

        public void AddAnimal(Bars animal)
        {
            if (animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Bars) || GetAnimalsType() == null)
            {
                animals.Add(animal);
                ClosedAnimals.Add(animal);
                SetSize();
            }
            else
            {
                MessageBox.Show("Неверный тип животного");
            }
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
            if (animals.Count == 0)
            {
                size = -1;
            }
            if (openAnimals.Contains(animal))
            {
                openAnimals.Remove(animal);
            }
            if (closedAnimals.Contains(animal))
            {
                closedAnimals.Remove(animal);
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

            return result + $"Еды: {Food} Размер: {size} Тип: {GetAnimalsType()}\n";
        }

        private void SetSize()
        {
            if (animals[0].GetType() == typeof(Horse))
            {
                size = 5;
            }
            else if (animals[0].GetType() == typeof(Capybara))
            {
                size = 10;
            }
            else if (animals[0].GetType() == typeof(Bars))
            {
                size = 15;
            }
            else
            {
                size = 0;
            }
        }

        public Enclouser(int id, Animal animal) 
        {
            Id = id;
            animals.Add(animal);
            Food = 0;

            SetSize();
        }
    }
}
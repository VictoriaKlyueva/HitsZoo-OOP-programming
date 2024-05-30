using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HitsZoo
{
    public class Enclouser: IEntity, IEnclouser
    {
        public Guid Id { get; } = Guid.NewGuid();

        private List<Animal> closedAnimals = new List<Animal>();
        public List<Animal> ClosedAnimals { get => closedAnimals; set => closedAnimals = value; }

        private List<Animal> openAnimals = new List<Animal>();
        public List<Animal> OpenAnimals { get => openAnimals; set => openAnimals = value; }

        private List<Animal> animals = new List<Animal>();
        public List<Animal> Animals { get => animals; set => animals = value; }
        public FoodMark Food { get; set; } = new Whiskas();

        private int size = -1;

        // Остальной код

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
            if (Food != null)
            {
                Food.RemoveFood(1);
            }
        }

        public bool IsFoodEmpty()
        {
            return (Food == default) || Food.IsEmpty();
        }

        public Type GetFoodMark()
        {
            return typeof(FoodMark);
        }

        public void UpdateFood<Mark>(int food) where Mark : FoodMark, new()
        {
            if (typeof(Mark) == GetFoodMark())  // Марка добавляемого корма совпадает с маркой текущего
            {
                Food.AddFood(food);
            }
            else if (Food == default) // Марка текущего корма неизвестна
            {
                Food = new Mark(); 
                Food.AddFood(food);
            }
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

            return result + $"Еды: {Food} Размер: {size} Тип: {GetAnimalsType()} " + (Food != null ? $"Тип еды: {Food.GetType()} Еда: {Food.PrintFood()}\n" : "Еды нет...");
        }

        private void SetSize()
        {
            if (animals[0].GetType() == typeof(Horse))
            {
                size = 7;
            }
            else if (animals[0].GetType() == typeof(Capybara))
            {
                size = 10;
            }
            else if (animals[0].GetType() == typeof(Bars))
            {
                size = 12;
            }
            else
            {
                size = 0;
            }
        }

        public void Update(IEntity entity)
        {
            if (IsFull())
            {
                Food = default;
            }
        }

        public Enclouser(Animal animal) 
        {
            animals.Add(animal);
            Food = default;

            SetSize();
        }

        public Enclouser(Animal animal, Guid id)
        {
            Id = id;
            animals.Add(animal);
            Food = default;

            SetSize();
        }
    }
}
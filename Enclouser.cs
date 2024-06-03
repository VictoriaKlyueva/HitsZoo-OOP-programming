using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HitsZoo
{
    public class Enclouser: IEntity, IEnclouser
    {
        public Guid Id { get; } = Guid.NewGuid();
        public List<Animal> ClosedAnimals { get; set; } = new List<Animal>();
        public List<Animal> OpenAnimals { get; set; } = new List<Animal>();

        public List<Animal> Animals { get; set; } = new List<Animal>();
        public FoodMark Food { get; set; }

        public bool IsLinked { get; set; } = false;

        private int size = -1;

        // Остальной код

        public bool IsFull()
        {
            return Animals.Count == size;
        }

        public Type GetAnimalsType()
        {
            if (Animals.Count == 0)
                return null;
            else if (Animals[0].GetType() == typeof(Horse))
            {
                return typeof(Horse);
            }
            else if (Animals[0].GetType() == typeof(Capybara))
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
            return ((Food == default) || Food.IsEmpty());
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
            if (Animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Horse) || GetAnimalsType() == null)
            {
                Animals.Add(animal);
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
            if (Animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Capybara) || GetAnimalsType() == null)
            {
                Animals.Add(animal);
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
            if (Animals.Count == size)
            {
                MessageBox.Show("Вольер переполнен");
                return;
            }
            if (GetAnimalsType() == typeof(Bars) || GetAnimalsType() == null)
            {
                Animals.Add(animal);
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
            Animals.Remove(animal);
            if (Animals.Count == 0)
            {
                size = -1;
            }
            if (OpenAnimals.Contains(animal))
            {
                OpenAnimals.Remove(animal);
            }
            if (ClosedAnimals.Contains(animal))
            {
                ClosedAnimals.Remove(animal);
            }
        }

        public string Print()
        {
            string result = $"ID: {Id} ";
            return result + $"Размер: {size} Тип: {GetAnimalsType()} " + (Food != null ? $"Тип еды: {Food.GetType()} Еда: {Food.PrintFood()}\n" : "Еды нет...");
        }

        private void SetSize()
        {
            if (Animals[0].GetType() == typeof(Horse))
            {
                size = 7;
            }
            else if (Animals[0].GetType() == typeof(Capybara))
            {
                size = 10;
            }
            else if (Animals[0].GetType() == typeof(Bars))
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
            if (IsFoodEmpty())
            {
                Food = default;
            }
        }

        public void ChangeLinkStatus()
        {
            this.IsLinked = !this.IsLinked;
        }

        public int CompareTo(IEntity other)
        {
            if (other is null) throw new NotImplementedException();
            return Id.ToString().CompareTo(other.Id.ToString());
        }

        public Enclouser(Animal animal) 
        {
            Animals.Add(animal);
            Food = default;

            SetSize();
        }

        public Enclouser(Animal animal, Guid id)
        {
            Id = id;
            Animals.Add(animal);
            Food = default;

            SetSize();
        }
    }
}
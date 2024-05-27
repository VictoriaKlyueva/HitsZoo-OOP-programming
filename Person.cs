using System;

namespace HitsZoo
{
    public abstract class Person : IEntity
    {
        public Guid Id2 { get; } = Guid.NewGuid();
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public void Edit(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Update(IEntity entity)
        {
            return;
        }

        public virtual string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}" +
                   $" Имя: {Name}  Возраст: {Age}";
        }
    }
}

using System;

namespace HitsZoo
{
    public abstract class Person : IEntity
    {
        public Guid Id2 { get; } = Guid.NewGuid();
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Edit(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void Update(IEntity entity)
        {
            return;
        }

        public virtual string Print()
        {
            return $"ID: {Id2} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}" +
                   $" Имя: {Name}  Возраст: {Age}";
        }
    }
}

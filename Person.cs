using System;

namespace HitsZoo
{
    public abstract class Person : IEntity
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Update(IEntity entity)
        {
            return;
        }

        public void Edit(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(IEntity other)
        {
            if (other is null) throw new NotImplementedException();
            return Id.ToString().CompareTo(other.Id.ToString());
        }

        public virtual string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}" +
                   $" Имя: {Name}  Возраст: {Age}";
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

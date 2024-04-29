using System;

namespace HitsZoo
{
    public class Person
    {
        public int id;
        public string name;
        public int age;

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void Edit(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Print()
        {
            return $"ID: {id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {name} " +
                              $" Возраст: {age}";
        }
    }
}

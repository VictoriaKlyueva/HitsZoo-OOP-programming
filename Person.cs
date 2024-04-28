using System;

namespace HitsZoo
{
    public class Person
    {
        public int id;
        public string type = "Посетитель";
        public string name;
        public int age;

        public Person(int id, string type, string name, int age)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.age = age;
        }

        public virtual void print()
        {
            Console.WriteLine($"ID: {id} Type: {type} Имя: {name} " +
                              $" Возраст: {age}");
        }
    }
}

using System;

namespace HitsZoo
{
    public class Visitor : Person
    {
        private int wallet;
        public Visitor(int id, string name, int age) : base(id, name, age) 
        {
            wallet = new Random().Next(20, 100);
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}" +
                   $" Имя: {Name}  Возраст: {Age}  Кошелек: {wallet}";
        }
    }
}

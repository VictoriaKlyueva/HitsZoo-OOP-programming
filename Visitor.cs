using System;

namespace HitsZoo
{
    public class Visitor : Person
    {
        private int wallet;
        private int foodCount;
        public Visitor(int id, string name, int age) : base(id, name, age) 
        {
            wallet = new Random().Next(10, 20);
        }

        public void BuyFood()
        {
            if (wallet !=  0)
            {
                wallet -= 1;
                foodCount++;
            }
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name}" +
                   $" Имя: {Name}  Возраст: {Age}  Кошелек: {wallet} Еды: {foodCount}";
        }
    }
}

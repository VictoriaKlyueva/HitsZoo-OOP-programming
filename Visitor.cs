﻿using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public class Visitor : Person
    {
        private int wallet;
        private int foodCount;

        private Random random = new Random();

        public void FeedAnimal(IEnclouser enclouser)
        {
            List<Animal> visibleAnimals = SeeAnimals(enclouser);

            if (foodCount > 0 && visibleAnimals.Count > 0)
            {
                int choice = random.Next(0, visibleAnimals.Count - 1);

                Animal choicedAnimal = visibleAnimals[choice];
                foodCount--;

                // Выбор марки корма
                int index = random.Next(0, 2);
                if (index == 0)
                {
                    choicedAnimal.Eat<Whiskas>();
                }
                else if (index == 1)
                {
                    choicedAnimal.Eat<Kitekat>();
                }
                else
                {
                    choicedAnimal.Eat<Pedigree>();
                }
            }
        }

        public List<Animal> SeeAnimals(IEnclouser enclouser)
        {
            return enclouser.OpenAnimals;
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

        public Visitor(string name, int age) : base(name, age)
        {
            wallet = random.Next(10, 20);
        }
    }
}

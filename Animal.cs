using System;

namespace HitsZoo
{
    public class Animal
    {
        int criticalHunger = new Random().Next(10, 20);
        public int currentHunger = 0;
        public bool isHungry = false;
        string voice = "meow";

        public void update()
        {
            if (currentHunger > criticalHunger)
            {
                isHungry = true;
            }
        }

        public void feed()
        {
            currentHunger = 0;
            isHungry = false;
        }

        public void submitVote()
        {
            Console.WriteLine(voice);
        }

        public void print()
        {
            Console.WriteLine($"Численный голод: {currentHunger}  " +
                              $" Голод: {isHungry}");
        }

        public Animal(string voice)
        {
            this.voice = voice;
        }
    }
}
using System;

namespace HitsZoo
{
    public class Animal
    {
        public int criticalHunger;
        public int currentHunger = 0;
        public bool isHungry = false;
        public string voice = "meow";

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
            Console.WriteLine($"Численный голод: {currentHunger} " +
                              $" Голод: {isHungry}");
        }

        public Animal(string voice, int criticalHunger=5)
        {
            this.voice = voice;
            this.criticalHunger = criticalHunger;
        }
    }
}
using System;

namespace HitsZoo
{
    public class Animal
    {
        public int id;
        public string type = "animal";
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

        public string print()
        {
            Console.WriteLine($"ID: {id} Type: {type} Численный голод: {currentHunger} " +
                              $" Голод: {isHungry}");
            return $"ID: {id} Type: {type} Численный голод: {currentHunger} " +
                              $" Голод: {isHungry}";
        }

        public Animal(int id, string type, string voice, int criticalHunger=5)
        {   
            this.id = id;
            this.type = type;
            this.voice = voice;
            this.criticalHunger = criticalHunger;
        }
    }
}
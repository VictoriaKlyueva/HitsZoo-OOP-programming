using System;

namespace HitsZoo
{
    public class Animal
    {
        public int id;
        public int criticalHunger;
        public int currentHunger = 0;
        public bool isHungry = false;
        public string voice = "meow";

        public void Update()
        {
            if (currentHunger > criticalHunger)
            {
                isHungry = true;
            }
            else
            {
                isHungry = false;
            }
        }

        public void Feed()
        {
            currentHunger = 0;
            isHungry = false;
        }

        public string SubmitVote()
        {
            Console.WriteLine(voice);
            return voice;
        }

        public string Print()
        {
            return $"ID: {id} Type: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Численный голод: {currentHunger} " +
                              $" Голод: {isHungry}";
        }

        public void Edit(int criticalHunger, string voice)
        {
            this.criticalHunger = criticalHunger;
            this.voice = voice;
        }

        public Animal(int id, string voice, int criticalHunger=5)
        {   
            this.id = id;
            this.voice = voice;
            this.criticalHunger = criticalHunger;
        }
    }
}
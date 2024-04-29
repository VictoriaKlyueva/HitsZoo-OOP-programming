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
        public bool isFree = true;

        public void Update()
        {
            currentHunger += 1;
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

        public virtual string Print()
        {
            return $"ID: {id} Class: Animal Голод: {currentHunger} {isHungry}";
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
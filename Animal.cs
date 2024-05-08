using System;

namespace HitsZoo
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public int CriticalHunger { get; set; }
        public int CurrentHunger { get; set; } = 0;
        public bool IsHungry { get; set; } = false;
        public string Voice { get; set; } = "meow";
        public bool IsFree { get; set; } = true;

        public int EnclouserId { get; set; } = -1;

        public void Update()
        {
            CurrentHunger += 1;
            if (CurrentHunger > CriticalHunger)
            {
                IsHungry = true;
            }
            else
            {
                IsHungry = false;
            }
        }

        public void Feed()
        {
            CurrentHunger = 0;
            IsHungry = false;
        }

        public string SubmitVote()
        {
            Console.WriteLine(Voice);
            return Voice;
        }

        public virtual string Print()
        {
            return $"ID: {Id} Class: Animal Голод: {CurrentHunger} {IsHungry}";
        }

        public void Edit(int criticalHunger, string voice)
        {
            CriticalHunger = criticalHunger;
            Voice = voice;
        }

        public override string ToString()
        {
            return Id.ToString(); 
        }

        public Animal(int id, string voice, int criticalHunger=5)
        {   
            Id = id;
            Voice = voice;
            CriticalHunger = criticalHunger;
        }
    }
}
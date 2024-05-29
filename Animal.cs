using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public abstract class Animal: IEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public int CriticalHunger { get; set; }
        public int CurrentHunger { get; set; } = 0;
        public bool IsHungry { get; set; } = false;
        public string Voice { get; set; } = "meow";
        public bool IsFree { get; set; } = true;

        public Guid EnclouserId { get; set; } = default;

        public virtual List<Type> EdibleFood { get; set; }

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

        public void Eat()
        {
            if (IsHungry)
            {
                CurrentHunger = 0;
                IsHungry = false;
            }
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

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public Animal(string voice, Guid enclouserId, int criticalHunger=5)
        {   
            Voice = voice;
            CriticalHunger = criticalHunger;
            EnclouserId = enclouserId;
        }
    }
}
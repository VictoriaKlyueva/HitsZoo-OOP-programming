using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public class Horse : Animal
    {
        public override List<Type> EdibleFood { get; set; }

        public override string Print()
        {
            string hungerStatus = (IsHungry) ? "Голоден" : "Сыт";
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} " +
                   $"Голод: {CurrentHunger} {hungerStatus} Вольер: {EnclouserId}";
        }

        public Horse(string voice, Guid enclouserId, int criticalHunger=5) : 
               base(voice, enclouserId, criticalHunger) 
        {
            EdibleFood = new List<Type> { typeof(Whiskas), typeof(Kitekat) };
        }
    }
}

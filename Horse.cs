using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Horse : Animal
    {
        public override string Print()
        {
            string hungerStatus = (IsHungry) ? "Голоден" : "Сыт";
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} " +
                   $"Голод: {CurrentHunger} {hungerStatus} Вольер: {EnclouserId}";
        }

        public Horse(int id, string voice, int enclouserId, int criticalHunger=5) : 
               base(id, voice, enclouserId, criticalHunger) { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Capybara : Animal
    {
        public override List<Type> EdibleFood { get; set; }

        public override string Print()
        {
            string hungerStatus = (IsHungry) ? "Голоден" : "Сыт";
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} " +
                   $"Голод: {CurrentHunger} {hungerStatus} Вольер: {EnclouserId}";
        }

        public Capybara(string voice, Guid enclouserId, int criticalHunger=10) :
               base(voice, enclouserId, criticalHunger)
        {
            EdibleFood = new List<Type> { typeof(Whiskas), typeof(Pedigree) };
        }
    }
}

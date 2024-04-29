﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Capybara : Animal
    {
        public override string Print()
        {
            return $"ID: {id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} " +
                   $"Голод: {currentHunger} {isHungry}";
        }

        public Capybara(int id, string voice, int criticalHunger=10) :
               base(id, voice, criticalHunger)
        { }
    }
}

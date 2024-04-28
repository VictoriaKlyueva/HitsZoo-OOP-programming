﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Capybara : Animal
    {
        public int criticalHunger = 15;
        public Capybara(int receivedId, string receivedType, string receivedVoice, int receivedCriticalHunger=10) :
               base(receivedId, receivedType, receivedVoice, receivedCriticalHunger)
        { }
    }
}
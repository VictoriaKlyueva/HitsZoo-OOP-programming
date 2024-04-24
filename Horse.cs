using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Horse : Animal
    {
        public Horse(string receivedVoice, int receivedCriticalHunger=5) : 
               base(receivedVoice, receivedCriticalHunger) { }
    }
}

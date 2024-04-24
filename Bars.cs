using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Bars : Animal
    {
        public Bars(string receivedVoice, int receivedCriticalHunger=15) :
               base(receivedVoice, receivedCriticalHunger)
        { }
    }
}

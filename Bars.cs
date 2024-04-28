using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Bars : Animal
    {
        public Bars(int receivedId, string receivedType, string receivedVoice, int receivedCriticalHunger=15) :
               base(receivedId, receivedType, receivedVoice, receivedCriticalHunger)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Kitekat : FoodMark
    {
        public override int CriticalWeight { get; set; }

        Kitekat()
        {
            CriticalWeight = 15;
        }
    }
}

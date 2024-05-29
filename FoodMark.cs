using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    abstract public class FoodMark
    {
        public virtual int CriticalWeight { get; set; }
        private int weight = 0;
    }
}

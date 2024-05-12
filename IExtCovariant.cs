using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    internal interface IExtCovariant<out T> : ICovariant<T> where T : Animal
    {

    }
}

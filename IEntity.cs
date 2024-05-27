using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public interface IEntity
    {
        Guid Id2 { get; }

        string Print();
    }
}

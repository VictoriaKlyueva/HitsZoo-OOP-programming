
using System.Collections.Generic;

namespace HitsZoo
{
    public interface IOpenSection<T> where T : Animal
    {
        List<T> OpenAnimals { get; set; }
    }
}

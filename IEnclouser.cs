using System.Collections.Generic;

namespace HitsZoo
{
    public interface IEnclouser<T>: IClosedSection<T>, IOpenSection<T> where T : Animal
    {
        List<T> Animals { get; set; }

        void AddAnimal(T animal);

        void RemoveAnimal(T animal);
    }
}

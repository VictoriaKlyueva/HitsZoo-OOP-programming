using System.Collections.Generic;

namespace HitsZoo
{
    public interface IEnclouser: IClosedSection, IOpenSection
    {
        List<Animal> Animals { get; set; }

        void AddAnimal(Animal animal);

        void RemoveAnimal(Animal animal);
    }
}

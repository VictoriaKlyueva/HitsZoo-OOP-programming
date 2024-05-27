using System.Collections.Generic;

namespace HitsZoo
{
    public interface IEnclouser: IClosedSection, IOpenSection, IFood
    {
        List<Animal> Animals { get; set; }

        void AddAnimal(Horse animal);
        void AddAnimal(Capybara animal);

        void AddAnimal(Bars animal);


        void RemoveAnimal(Animal animal);
    }
}

using System.Collections.Generic;

namespace HitsZoo
{
    public class Enclouser: IEnclouser
    {
        public int Id { get; set; }
        private List<Animal> animals = new List<Animal>();
        private int size;
        private int food = 0;

        public string Print()
        {
            string result = $"ID: {Id} Animals: ";
            for (int i = 0; i < animals.Count; i++)
            {
                result += animals[i].ToString() + " ";
            }

            return result +  $"Еды: {food} \n";
        }

        public void addAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public Enclouser(int id, Animal animal) 
        {
            Id = id;
            animals.Add(animal);
        }
    }
}
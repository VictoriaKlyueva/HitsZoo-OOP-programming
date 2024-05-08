using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public class Staff : Person
    {
        public string occupation;
        public int wardAnimalId = -1;
        public Staff(int id, string name, int age, string occupation, int wardAnimalId) : base(id, name, age)
        {
            this.occupation = occupation;
            this.wardAnimalId = wardAnimalId;
        }

        public void Update(Animal animal)
        {
            if (animal.IsHungry)
            {
                animal.Feed();
            }
        }

        public void Edit(string name, int age, string occupation, int wardAnimalId)
        {
            Edit(name, age);
            this.occupation = occupation;
            this.wardAnimalId = wardAnimalId;
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {Name} " +
                              $" Возраст: {Age} Должность: {occupation} Животное: {wardAnimalId} \n";
        }
    }
}

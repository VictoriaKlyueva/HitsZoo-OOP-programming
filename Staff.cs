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

        public void Edit(string name, int age, string occupation, int wardAnimalId)
        {
            Edit(name, age);
            this.occupation = occupation;
            this.wardAnimalId = wardAnimalId;
        }

        public override string Print()
        {
            return $"ID: {id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {name} " +
                              $" Возраст: {age} Должность: {occupation} Животное: {wardAnimalId} \n";
        }
    }
}

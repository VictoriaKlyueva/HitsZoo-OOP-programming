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
        public int wardAnimalId;
        public Staff(int id, string name, int age, string occupation) : base(id, name, age)
        {
            this.occupation = occupation;
        }

        public void Edit(string name, int age, string occupation)
        {
            Edit(name, age);
            this.occupation = occupation;
        }

        public override string Print()
        {
            return $"ID: {id} Type: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {name} " +
                              $" Возраст: {age} Должность: {occupation} Животное: {wardAnimalId} \n";
        }
    }
}

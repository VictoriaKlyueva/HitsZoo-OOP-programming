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
        public Staff(int id, string type, string name, int age, string occupation) : base(id, type, name, age)
        {
            this.occupation = occupation;
        }

        public override string print()
        {
            Console.WriteLine($"ID: {id} Type: {type} Имя: {name} " +
                              $" Возраст: {age} Должность: {occupation} Животное: {wardAnimalId}");
            return $"ID: {id} Type: {type} Имя: {name} " +
                              $" Возраст: {age} Должность: {occupation} Животное: {wardAnimalId} \n";
        }
    }
}

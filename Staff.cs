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
        public Staff(string name, int age, string occupation) : base(name, age)
        {
            this.occupation = occupation;
        }

        public override void print()
        {
            Console.WriteLine(name + " " + age + " " + occupation);
        }
    }
}

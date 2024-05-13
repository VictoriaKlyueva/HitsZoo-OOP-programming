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
        public int wardEnclouserId = -1;
        public Staff(int id, string name, int age, string occupation, int wardEnclouserId) : base(id, name, age)
        {
            this.occupation = occupation;
            this.wardEnclouserId = wardEnclouserId;
        }

        public void Update(Enclouser enclouser)
        {
            if (enclouser.IsFoodEmpty())
            {
                enclouser.UpdateFood(10);
            }
        }

        public void Edit(string name, int age, string occupation, int wardEnclouserId)
        {
            Edit(name, age);
            this.occupation = occupation;
            this.wardEnclouserId = wardEnclouserId;
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {Name} " +
                              $" Возраст: {Age} Должность: {occupation} Вольер: {wardEnclouserId} \n";
        }
    }
}

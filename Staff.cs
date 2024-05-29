using System;

namespace HitsZoo
{
    public class Staff : Person
    {
        public string occupation;
        public Guid wardEnclouserId = default;

        public Staff(string name, int age, string occupation, Guid wardEnclouserId=default) : base(name, age)
        {
            this.occupation = occupation;
            this.wardEnclouserId = wardEnclouserId;
        }

        public void Update(IEnclouser enclouser)
        {
            if (wardEnclouserId != default)
            {
                if (enclouser.IsFoodEmpty())
                {
                    enclouser.UpdateFood(10);
                }
            }
        }

        public void Edit(string name, int age, string occupation, Guid wardEnclouserId)
        {
            Edit(name, age);
            this.occupation = occupation;
            this.wardEnclouserId = default;
        }

        public override string Print()
        {
            return $"ID: {Id2} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {Name} " +
                              $" Возраст: {Age} Должность: {occupation} Вольер: {wardEnclouserId} \n";
        }
    }
}

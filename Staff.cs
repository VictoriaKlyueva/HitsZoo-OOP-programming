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

        public override void Update(IEntity entity)
        {
            if (wardEnclouserId != default)
            {
                if (((Enclouser)entity).IsFoodEmpty())
                {
                    ((Enclouser)entity).UpdateFood(10);
                }
            }
        }

        public void Edit(string name, int age, string occupation, Guid id=default)
        {
            Edit(name, age);
            this.occupation = occupation;
            this.wardEnclouserId = id;
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {Name} " +
                              $" Возраст: {Age} Должность: {occupation} Вольер: {wardEnclouserId} \n";
        }
    }
}

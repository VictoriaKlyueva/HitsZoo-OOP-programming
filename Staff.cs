using System;
using System.Collections.Generic;

namespace HitsZoo
{
    public class Staff : Person
    {
        public string Occupation { get; set; }
        public Guid WardEnclouserId { get; set; } = default;

        public override void Update(IEntity entity)
        {
            if (WardEnclouserId != default)
            {
                if (((Enclouser)entity).IsFoodEmpty())
                {
                    int index = new Random().Next(0, 2);

                    if (index == 0)
                    {
                        ((Enclouser)entity).UpdateFood<Whiskas>(new Random().Next(5, 15));
                    }
                    else if (index == 1) 
                    {
                        ((Enclouser)entity).UpdateFood<Kitekat>(new Random().Next(5, 15));
                    }
                    else
                    {
                        ((Enclouser)entity).UpdateFood<Pedigree>(new Random().Next(5, 15));
                    }
                }
            }
        }

        public void Edit(string name, int age, string occupation, Guid id=default)
        {
            Edit(name, age);
            this.Occupation = occupation;
            this.WardEnclouserId = id;
        }

        public override string Print()
        {
            return $"ID: {Id} Class: {System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name} Имя: {Name} " +
                              $" Возраст: {Age} Должность: {Occupation} Вольер: {WardEnclouserId} \n";
        }

        public Staff(string name, int age, string occupation, Guid wardEnclouserId = default) : base(name, age)
        {
            this.Occupation = occupation;
            this.WardEnclouserId = wardEnclouserId;
        }
    }
}

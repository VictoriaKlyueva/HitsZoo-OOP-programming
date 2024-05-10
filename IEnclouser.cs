﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitsZoo
{
    public interface IEnclouser
    {
        void AddAnimal(Animal animal);

        void RemoveAnimal(Animal animal);

    }
}
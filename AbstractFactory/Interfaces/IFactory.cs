using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    internal interface IFactory
    {
        IAnimal CreateAnimal(string name);
    }
}

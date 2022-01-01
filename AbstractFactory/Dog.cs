using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    class Dog : IDog, IAnimal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

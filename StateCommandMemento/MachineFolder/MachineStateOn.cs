using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    internal class MachineStateOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Machine is now OFF");
            
        }

        public void Print(string message, Machine machine)
        {
            Console.WriteLine(message);
        }
    }
}

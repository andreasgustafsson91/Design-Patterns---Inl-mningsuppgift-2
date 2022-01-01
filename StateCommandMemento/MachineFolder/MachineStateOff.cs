using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    internal class MachineStateOff : IMachineState
    {
        public List<ICommand> Commands { get; set; }
        

        public MachineStateOff(List<ICommand> commands)
        {            
            Commands = commands;

        }
        public void PowerSwitch()
        {
            Console.WriteLine("Machine is now ON");
            
        }

       

        public void Print(string message, Machine machine)
        {
            ICommand command = new PrintCommand(machine, message);
            Console.WriteLine("Message saved.");
            Commands.Add(command);
        }
    }
}

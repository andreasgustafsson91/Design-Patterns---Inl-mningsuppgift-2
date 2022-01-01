using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Machine
    {
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }
        

        public Machine()
        {
            Commands = new List<ICommand>();
            MachineState = new MachineStateOff(Commands);
        }
        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineStateOff)
            {
                MachineState = new MachineStateOn();
                foreach (var command in Commands)
                {
                    command.Execute();
                    
                }
                Commands.Clear();
            }
            else
            {
                MachineState = new MachineStateOff(Commands);
            }
            
        }

        public void Print(string message)
        {
            MachineState.Print(message, this);
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, MachineState, Commands);
        }
    }
}

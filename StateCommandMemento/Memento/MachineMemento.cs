using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineMemento
    {
        public Machine Machine { get; set; }
        public IMachineState MachineState { get; set; }
        public List<ICommand> Commands { get; set; }
        public MachineMemento(Machine machine, IMachineState machineState, List<ICommand> commands )
        {
            Machine = machine;
            MachineState = machineState;
            Commands = commands;
        }

        public void Revert()
        {
            Machine.MachineState = MachineState;
            Machine.Commands = Commands;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrintCommand : ICommand
    {
        public Machine Machine{ get; set; }
        public string Message { get; set; }

        public PrintCommand(Machine machine, string message)
        {
            Machine = machine;
            Message = message;
        }

        public void Execute()
        {
            Machine.Print(Message);
        }

        public void Unexecute()
        {
            Console.WriteLine("¯l_(ツ)_/¯");
        }
    }
}

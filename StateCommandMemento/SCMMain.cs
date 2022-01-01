using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */

        public string Message { get; set; }
        
        public void Run()
        {
            Machine machine = new Machine();
            List<MachineMemento> mementos = new();
            mementos.Add(machine.CreateMemento());
            Instructions();

            while (true)
            {
                var userinput = Console.ReadKey(true).Key;
                switch (userinput)
                {
                    case ConsoleKey.O:
                        machine.PowerSwitch();
                        break;

                    case ConsoleKey.R:
                        Console.WriteLine("Reverting to default settings.");
                        mementos.FirstOrDefault().Revert();
                        Message = null;
                        break;

                    case ConsoleKey.M:
                        Console.WriteLine("Enter your message for the printer:");
                        Message = Console.ReadLine();
                        Console.WriteLine("Gotcha");
                        break;

                    case ConsoleKey.I:
                        Instructions();
                        break;

                    case ConsoleKey.P:
                        if (Message != null)
                        {
                            machine.Print(Message);
                        }
                        else
                        {
                            Console.WriteLine("There is nothing to print");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        break;
                }
            }
        }

        public void Instructions()
        {
            Console.WriteLine("Press Enter to Start/Stop the machine.");
            Console.WriteLine("Press M to enter message for printer.");
            Console.WriteLine("Press P to print.");
            Console.WriteLine("Press I to see this information again.");
            Console.WriteLine("Press R to Restore the machine to default settings.");
            Console.WriteLine("Press space for emergency brakes.");
        }
    }
}
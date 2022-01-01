using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    class AdapterMain
    {
        public void Run()
        {
            // Skriv en adapter för ReturningStrings som kan konsumeras av PrintingInts           
            

            Adapters adapters = new Adapters();
            ReturningStrings returningStrings = new();
            PrintingInts printingInts = new();
            
            printingInts.Print(adapters.StringToIntAdapter(returningStrings.ReturnString()));
            
            Console.ReadLine();
        }
    }
}

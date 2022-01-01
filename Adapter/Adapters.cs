using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    internal class Adapters
    {
        public int StringToIntAdapter(string input)
        {
            int output = Convert.ToInt32(input);
            return output;
        }
    }
}

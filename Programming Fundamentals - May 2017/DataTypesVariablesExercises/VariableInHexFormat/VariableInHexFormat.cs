using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string numInHex = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(numInHex, 16));
        }
    }
}

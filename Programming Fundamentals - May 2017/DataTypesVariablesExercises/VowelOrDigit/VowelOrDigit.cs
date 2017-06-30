using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol.ToString().ToLower() == "a"
                || symbol.ToString().ToLower() == "e"
                || symbol.ToString().ToLower() == "i"
                || symbol.ToString().ToLower() == "o"
                || symbol.ToString().ToLower() == "u")
            {
                Console.WriteLine("vowel");
            }
            else if (symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

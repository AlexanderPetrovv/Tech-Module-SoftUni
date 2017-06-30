using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings2
{
    class ReverseAnArrayOfStrings2
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();

            string[] reversed = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                reversed[str.Length - i - 1] = str[i];
            }
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}

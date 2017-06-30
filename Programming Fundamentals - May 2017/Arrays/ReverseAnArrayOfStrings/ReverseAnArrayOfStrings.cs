using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to read an array of strings, reverse it and print its elements.
The input consists of a sequence of space separated strings.
Print the output on a single line (space separated).
*/

namespace ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();

            var reversedStr = str.Reverse();
            Console.WriteLine(string.Join(" ", reversedStr));
        }
    }
}

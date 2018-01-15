using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}

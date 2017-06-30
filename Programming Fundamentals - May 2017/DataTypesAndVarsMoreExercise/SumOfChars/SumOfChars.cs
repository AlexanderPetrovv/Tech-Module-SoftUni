using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program, which sums the ASCII codes of n characters and prints the sum on the console.
*/

namespace SumOfChars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int lineCnt = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < lineCnt; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += (int)symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

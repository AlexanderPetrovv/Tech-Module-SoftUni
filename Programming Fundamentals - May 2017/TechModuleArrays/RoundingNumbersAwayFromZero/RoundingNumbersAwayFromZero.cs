using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program to read an array of real numbers (space separated values),
round them to the nearest integer in "away from 0" style and print the output.
- To round to the nearest integer, e.g. 2.9 -> 3; -1.75 -> -2
- In case the number is exactly in the middle of two integers (midpoint value),
round it to the next integer which is away from the 0
*/

namespace RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

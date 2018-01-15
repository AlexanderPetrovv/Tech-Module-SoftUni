using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string inputNumbers = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(inputNumbers, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}

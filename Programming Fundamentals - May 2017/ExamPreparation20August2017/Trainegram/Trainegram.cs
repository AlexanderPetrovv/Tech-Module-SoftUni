using System;
using System.Text.RegularExpressions;

namespace Trainegram
{
    class Trainegram
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\<\[[^\da-zA-Z]*\]\.{1})+(\.{1}\[[a-zA-Z\d]*\]\.{1})*$";

            string input;

            while ((input = Console.ReadLine()) != "Traincode!")
            {
                Regex trainRegex = new Regex(pattern);

                if (trainRegex.IsMatch(input))
                {
                    Match trainMatch = trainRegex.Match(input);
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(trainMatch);
                    //Console.ResetColor();
                }
            }
        }
    }
}

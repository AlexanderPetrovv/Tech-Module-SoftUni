using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            Regex firstRegex = new Regex(@"[^a-zA-Z\-]+");
            Regex secondRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");

            string input = Console.ReadLine();                        

            while (true)
            {
                Match firstMatch = firstRegex.Match(input);
                if (firstMatch.Success)
                {
                    Console.WriteLine(firstMatch.Value);
                    int firstIndex = firstMatch.Index;
                    input = input.Substring(firstIndex + firstMatch.Length);
                }
                else
                {
                    break;
                }

                Match secondMatch = secondRegex.Match(input);
                if (secondMatch.Success)
                {
                    Console.WriteLine(secondMatch.Value);
                    int secondIndex = secondMatch.Index;
                    input = input.Substring(secondIndex + secondMatch.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}

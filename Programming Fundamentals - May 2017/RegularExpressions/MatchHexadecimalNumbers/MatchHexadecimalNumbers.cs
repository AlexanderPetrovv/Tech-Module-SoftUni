using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string regex = @"\b(0x)?[0-9A-F]+\b";  //@"\b(?:0x)?[0-9A-F]+\b"

            string input = Console.ReadLine();

            string[] numbers = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

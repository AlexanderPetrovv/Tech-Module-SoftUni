using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string cardsInput = Console.ReadLine();

            string regex = @"(^|(?<=[SHDC]))([2-9JQKA]|10)[SHDC]";

            string[] cards = Regex.Matches(cardsInput, regex)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}

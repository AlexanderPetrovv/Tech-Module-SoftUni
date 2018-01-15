using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace WormIpsum
{
    class WormIpsum
    {
        static void Main(string[] args)
        {
            string sentencePattern = @"^[A-Z][^\.\?!]*\.$";

            string wordPattern = @"\b[a-zA-Z\d-']+\b";

            string input;
            while ((input = Console.ReadLine()) != "Worm Ipsum")
            {
                Regex sentenceRegex = new Regex(sentencePattern);

                if (sentenceRegex.IsMatch(input))
                {
                    StringBuilder result = new StringBuilder();

                    string[] words = Regex.Matches(input, wordPattern).Cast<Match>().Select(x => x.Value).ToArray();

                    foreach (var word in words)
                    {
                        if (word.Distinct().Count() != word.Length)
                        {
                            var letter = word.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                            input = Regex.Replace(input, word, new string(letter, word.Length));
                        }
                    }

                    Console.WriteLine(input);
                }
            }
        }
    }
}

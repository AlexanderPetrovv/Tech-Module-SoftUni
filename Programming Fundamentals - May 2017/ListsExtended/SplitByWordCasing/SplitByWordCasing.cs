using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in input)
            {
                var type = GetWordType(word);
                if (type == WordType.UpperCase)
                {
                    upperCase.Add(word);
                }
                else if (type == WordType.LowerCase)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }

        enum WordType { UpperCase, MixedCase, LowerCase };

        static WordType GetWordType(string word)
        {
            int lowerCaseChars = 0;
            int upperCaseChars = 0;
            foreach (char letter in word)
            {
                if (char.IsUpper(letter))
                {
                    upperCaseChars++;
                }
                else if (char.IsLower(letter))
                {
                    lowerCaseChars++;
                }
            }

            if (upperCaseChars == word.Length)
            {
                return WordType.UpperCase;
            }
            else if (lowerCaseChars == word.Length)
            {
                return WordType.LowerCase;
            }
            return WordType.MixedCase;
        }
    }
}

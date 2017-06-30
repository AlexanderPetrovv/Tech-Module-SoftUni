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
            char[] separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            foreach (var word in text)
            {
                var type = GetWordType(word);
                if (type == WordType.LowerCase)
                {
                    lowerCaseWords.Add(word);
                }
                else if (type == WordType.UpperCase)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }

        enum WordType { UpperCase, MixedCase, LowerCase };

        static WordType GetWordType(string word)
        {
            int lowerCaseChars = 0;
            int upperCaseChars = 0;
            foreach (char letter in word)
            {
                if (char.IsLower(letter))
                {
                    lowerCaseChars++;
                }
                else if (char.IsUpper(letter))
                {
                    upperCaseChars++;
                }
            }

            if (lowerCaseChars == word.Length)
            {
                return WordType.LowerCase;
            }
            else if (upperCaseChars == word.Length)
            {
                return WordType.UpperCase;
            }
            return WordType.MixedCase;
        }
    }
}

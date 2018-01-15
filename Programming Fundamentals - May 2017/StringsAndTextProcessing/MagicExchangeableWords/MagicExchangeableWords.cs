using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];

            bool areExchangeable = ReturnExchangeableStatus(first, second);
            Console.WriteLine(areExchangeable.ToString().ToLower());
        }

        static bool ReturnExchangeableStatus(string first, string second)
        {
            var charDict = new Dictionary<char, char>();

            int shorterStrLength = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shorterStrLength; i++)
            {
                var firstCurrentChar = first[i];
                var secondCurrentChar = second[i];

                if (!charDict.ContainsKey(firstCurrentChar))
                {
                    if (!charDict.ContainsValue(secondCurrentChar))
                    {
                        charDict[firstCurrentChar] = secondCurrentChar;
                    }
                    else
                    {
                        return false;
                    }                  
                }
                else
                {
                    if (charDict[firstCurrentChar] != secondCurrentChar)
                    {
                        return false;
                    }
                }
            }

            var longerString = first.Length > second.Length ? first : second;

            for (int i = shorterStrLength; i < longerString.Length; i++)
            {
                var currentChar = longerString[i];

                if (!(charDict.ContainsKey(currentChar)) && !(charDict.ContainsValue(currentChar)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

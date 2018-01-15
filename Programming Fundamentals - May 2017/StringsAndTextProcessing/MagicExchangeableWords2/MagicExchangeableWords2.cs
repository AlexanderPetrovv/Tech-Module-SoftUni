using System;
using System.Collections.Generic;

namespace MagicExchangeableWords2
{
    class MagicExchangeableWords2
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            HashSet<char> firstWordSymbols = new HashSet<char>(firstWord);
            HashSet<char> secondWordSymbols = new HashSet<char>(secondWord);

            Console.WriteLine(firstWordSymbols.Count == secondWordSymbols.Count ? "true" : "false");
        }
    }
}

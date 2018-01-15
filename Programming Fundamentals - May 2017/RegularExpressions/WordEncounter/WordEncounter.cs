using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordEncounter
{
    class WordEncounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char letter = input[0];
            int occurences = input[1] - '0';

            string sentence = Console.ReadLine();
            List<string> filteredWords = new List<string>();

            while (sentence != "end")
            {
                Regex validSentence = new Regex(@"^[A-Z].*[\.\?!]$");
                if (validSentence.IsMatch(sentence))
                {
                    Regex wordRegex = new Regex(@"\b\w+\b");

                    MatchCollection words = wordRegex.Matches(sentence);

                    foreach (Match match in words)
                    {
                        string word = match.Value;
                        if (IsValidWord(word, letter, occurences))
                        {
                            filteredWords.Add(word);
                        }
                    }
                }
                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", filteredWords));
        }

        static bool IsValidWord(string word, char letter, int occurences)
        {
            int index = word.IndexOf(letter);
            int cnt = 0;

            while (index != -1)
            {
                index = word.IndexOf(letter, index + 1);
                cnt++;
            }
            return cnt >= occurences;
        }
    }
}

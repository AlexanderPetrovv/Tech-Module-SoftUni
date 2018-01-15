using System;
using System.Text;

namespace CapitalizeWords2
{
    class CapitalizeWords2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] words = line.Split(GetPunctuationDelimiter(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = CapitalizeFirstLetter(words[i]);
                }

                Console.WriteLine(string.Join(", ", words));

                line = Console.ReadLine();
            }
        }

        static char[] GetPunctuationDelimiter()
        {
            return new char[] { ' ', '.', ',', '!', '?', '-', '<', '>', '[', ']', '{', '}',
                                '(', ')', '\\', '/', '\"', '+', '-', ':', ';', '#', '&', '*' };
        }

        static string CapitalizeFirstLetter(string input)
        {
            StringBuilder resultWord = new StringBuilder(input);

            resultWord[0] = char.ToUpper(resultWord[0]);

            for (int i = 1; i < resultWord.Length; i++)
            {
                resultWord[i] = char.ToLower(resultWord[i]);
            }
            return resultWord.ToString();
        }
    }
}

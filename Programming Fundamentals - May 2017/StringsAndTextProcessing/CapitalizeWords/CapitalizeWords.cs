using System;

namespace CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            char[] delimiter = 
                { ' ', '.', ',', '!', '?', '-', '<', '>', '[', ']', '{', '}',
                '(', ')', '\\', '/', '\"', '+', '-', ':', ';', '#', '&', '*' };

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] words = line.ToLower().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                string[] finalWords = new string[words.Length];

                for (int w = 0; w < words.Length; w++)
                {
                    finalWords[w] = words[w][0].ToString().ToUpper() + words[w].Substring(1);
                }

                Console.WriteLine(string.Join(", ", finalWords));

                line = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] input = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i], 0);
                }
                words[input[i]]++;
            }

            List<string> oddWords = new List<string>();

            foreach (KeyValuePair<string, int> word in words)
            {
                if(word.Value % 2 == 1)
                {
                    oddWords.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddWords));
        }
    }
}

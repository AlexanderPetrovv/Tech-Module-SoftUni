using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();

            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var wordsCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCounts[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordsCounts.ContainsKey(word))
                {
                    wordsCounts[word]++;
                }
            }

            string[] orderedWordsCounts = wordsCounts
                .OrderByDescending(w => w.Value)
                .ThenBy(w => w.Key)
                .Select(w => w.Key + " - " + w.Value)
                .ToArray();

            File.WriteAllLines("result.txt", orderedWordsCounts);
        }
    }
}

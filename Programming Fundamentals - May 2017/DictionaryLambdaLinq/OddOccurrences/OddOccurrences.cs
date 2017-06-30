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
            List<string> text = Console.ReadLine().ToLower().Split().ToList();

            var occurrences = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (occurrences.ContainsKey(word))
                {
                    occurrences[word]++;
                }
                else
                {
                    occurrences[word] = 1;
                }
            }

            List<string> result = new List<string>();
            foreach (var item in occurrences.Keys)
            {
                if (occurrences[item] % 2 == 1)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

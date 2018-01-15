using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Dictionary<char, int> result = new Dictionary<char, int>();

            for (int i = 0; i < chars.Length; i++)
            {
                if(!result.ContainsKey(chars[i]))
                {
                    result.Add(chars[i], 0);
                }
                result[chars[i]]++;
            }

            foreach (KeyValuePair<char, int> pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}

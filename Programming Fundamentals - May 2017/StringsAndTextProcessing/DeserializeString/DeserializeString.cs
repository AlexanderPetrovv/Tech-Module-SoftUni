using System;
using System.Collections.Generic;
using System.Linq;

namespace DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var data = new Dictionary<char, List<int>>();

            while (!line.Equals("end"))
            {
                string[] tokens = line.Split(':', '/');
                char symbol = char.Parse(tokens[0]);
                int[] positions = tokens.Skip(1).Select(int.Parse).ToArray();

                if (!data.ContainsKey(symbol))
                {
                    data[symbol] = new List<int>(positions);
                }

                line = Console.ReadLine();
            }

            int strLength = data.Select(ch => ch.Value.Count).Sum();
            var charArr = new char[strLength];

            foreach (var ch in data)
            {
                var symbol = ch.Key;
                var positions = ch.Value;
                foreach (int pos in positions)
                {
                    charArr[pos] = symbol;
                }
            }

            Console.WriteLine(new string(charArr));
        }
    }
}

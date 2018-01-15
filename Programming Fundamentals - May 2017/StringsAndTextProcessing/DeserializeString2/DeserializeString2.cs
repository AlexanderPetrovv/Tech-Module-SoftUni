using System;
using System.Collections.Generic;
using System.Linq;

namespace DeserializeString2
{
    class DeserializeString2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var positionsSymbols = new SortedDictionary<int, char>();

            while (line != "end")
            {
                string[] tokens = line.Split(':', '/');
                char symbol = tokens[0][0];
                int[] positions = tokens.Skip(1).Select(int.Parse).ToArray();

                foreach (var pos in positions)
                {
                    positionsSymbols[pos] = symbol;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(new string(positionsSymbols.Values.ToArray()));
        }
    }
}

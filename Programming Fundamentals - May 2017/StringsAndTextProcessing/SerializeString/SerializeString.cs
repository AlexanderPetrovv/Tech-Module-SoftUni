using System;
using System.Collections.Generic;
using System.Text;

namespace SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var uniqueSymbols = new HashSet<char>();

            foreach (char ch in str)
            {
                uniqueSymbols.Add(ch);
            }           

            foreach (char symbol in uniqueSymbols)
            {
                int index = str.IndexOf(symbol);
                var strBuilder = new StringBuilder();
                strBuilder.Append($"{symbol}:");
                while (index != -1)
                {
                    strBuilder.Append($"{index}/");
                    index = str.IndexOf(symbol, index + 1);            
                }
                strBuilder.Remove(strBuilder.Length - 1, 1);
                Console.WriteLine(strBuilder.ToString());
            }
        }
    }
}

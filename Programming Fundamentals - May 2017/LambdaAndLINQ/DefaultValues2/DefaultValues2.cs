using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues2
{
    class DefaultValues2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var dict = new Dictionary<string, string>();

            while (line != "end")
            {
                string[] tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string key = tokens[0];
                string value = tokens[1];

                dict[key] = value;

                line = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            dict
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} <-> {x.Value}"));

            dict
                .Where(x => x.Value == "null")
                .Select(x => x + " <-> " + defaultValue)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}

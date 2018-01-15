using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues3
{
    class DefaultValues3
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

            var unchangedValues = dict
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value); ;

            var changedValues = dict
                .Where(x => x.Value == "null")
                .Select(x => new KeyValuePair<string, string>(x.Key, defaultValue))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in unchangedValues)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }

            foreach (var entry in changedValues)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }
        }
    }
}

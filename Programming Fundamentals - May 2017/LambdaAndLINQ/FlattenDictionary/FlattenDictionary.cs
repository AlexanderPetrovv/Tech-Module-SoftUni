using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var initialDict = new Dictionary<string, Dictionary<string, string>>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');

                if (tokens[0] != "flatten")
                {
                    string key = tokens[0];
                    string innerKey = tokens[1];
                    string innerValue = tokens[2];

                    if (!initialDict.ContainsKey(key))
                    {
                        initialDict[key] = new Dictionary<string, string>();
                    }

                    initialDict[key][innerKey] = innerValue;
                }
                else
                {
                    string key = tokens[1];
                    initialDict[key] = initialDict[key].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                line = Console.ReadLine();
            }

            var orderedDict = initialDict
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDict)
            {
                Console.WriteLine($"{entry.Key}");

                Dictionary<string, string> orderedInnerDict = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                int cnt = 1;
                foreach (var innerEntry in orderedInnerDict)
                {
                    Console.WriteLine($"{cnt}. {innerEntry.Key} - {innerEntry.Value}");
                    cnt++;
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine($"{cnt}. {flattenedEntry.Key}");
                    cnt++;
                }
            }           
        }
    }
}

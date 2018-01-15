using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary2
{
    class FlattenDictionary2
    {
        static void Main(string[] args)
        {
            var initialDict = new Dictionary<string, Dictionary<string, string>>();
            var flattenDict = new Dictionary<string, List<string>>();

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

                    if (!initialDict[key].ContainsKey(innerKey))
                    {
                        initialDict[key].Add(innerKey, String.Empty);
                    }

                    initialDict[key][innerKey] = innerValue;
                }
                else
                {
                    string flattenKey = tokens[1];

                    foreach (var entry in initialDict)
                    {
                        string key = entry.Key;
                        var innerDict = entry.Value;

                        if (key == flattenKey)
                        {
                            foreach (var innerEntry in innerDict)
                            {
                                string flattenedValue = innerEntry.Key + innerEntry.Value;

                                if (!flattenDict.ContainsKey(key))
                                {
                                    flattenDict[key] = new List<string>();
                                }

                                flattenDict[key].Add(flattenedValue);
                            }
                        }
                    }

                    initialDict[flattenKey] = new Dictionary<string, string>();
                }

                line = Console.ReadLine();
            }

            var orderedDict = initialDict.OrderByDescending(x => x.Key.Length);

            foreach (var entry in orderedDict)
            {
                string key = entry.Key;
                var innerDict = entry.Value.OrderBy(x => x.Key.Length);

                Console.WriteLine($"{key}");

                int cnt = 1;
                foreach (var innerEntry in innerDict)
                {
                    Console.WriteLine($"{cnt}. {innerEntry.Key} - {innerEntry.Value}");
                    cnt++;
                }

                if (flattenDict.ContainsKey(key))
                {
                    foreach (var flattenValue in flattenDict[key])
                    {
                        Console.WriteLine($"{cnt}. {flattenValue}");
                        cnt++;
                    }
                }
            }
        }
    }
}

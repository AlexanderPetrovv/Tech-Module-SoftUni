using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQuistics
{
    class LINQuistics
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var dictionary = new Dictionary<string, List<string>>();

            while (line != "exit")
            {
                string[] tokens = line.Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                string collection = tokens[0];
                int number;

                if (tokens.Length > 1)
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        string currentMethod = tokens[i];
                        if (!dictionary.ContainsKey(collection))
                        {
                            dictionary[collection] = new List<string>();
                        }

                        if (!dictionary[collection].Contains(currentMethod))
                        {
                            dictionary[collection].Add(currentMethod);
                        }
                    }
                }
                else if (int.TryParse(collection, out number))
                {
                    if (dictionary.Count > 0)
                    {
                        var mostMethordsCollection = dictionary.OrderByDescending(x => x.Value.Count()).First();
                        var methodsToPrint = mostMethordsCollection.Value.OrderBy(method => method.Length).Take(number);

                        PrintMethods(methodsToPrint);
                    }
                }
                else if (dictionary.ContainsKey(collection))
                {
                    var orderedDictionary = dictionary
                    .ToDictionary(dict => dict.Key, dict => dict.Value
                        .OrderByDescending(method => method.Length)
                        .ThenByDescending(method => method.Distinct().Count())
                        .ToList());

                    PrintMethods(orderedDictionary[collection]);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            string[] commandTokens = line.Split(' ');
            string methodToSearch = commandTokens[0];
            string selection = commandTokens[1];

            var collectionsToPrint = dictionary
                .Where(x => x.Value.Contains(methodToSearch))
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Value
                    .OrderBy(y => y.Length)
                    .First()
                    .Length)
                .ToList();

            foreach (var collection in collectionsToPrint)
            {
                string collectionName = collection.Key;
                var collectionMethods = collection.Value.OrderByDescending(x => x.Length);
                Console.WriteLine(collectionName);
                if (selection == "all")
                {
                    PrintMethods(collectionMethods);
                }
            }
        }

        static void PrintMethods (IEnumerable<string> methods)
        {
            foreach (var method in methods)
            {
                Console.WriteLine($"* {method}");
            }
        }
    }
}

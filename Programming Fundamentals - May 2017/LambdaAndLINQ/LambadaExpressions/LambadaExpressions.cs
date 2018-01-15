using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (line != "lambada")
            {
                string[] tokens = line.Split(new char[] { '=', '>', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "dance")
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string property = tokens[2];

                    if (!dictionary.ContainsKey(selector))
                    {
                        dictionary[selector] = new Dictionary<string, string>();
                    }

                    dictionary[selector][selectorObject] = property;
                }
                else
                {
                    dictionary = dictionary
                        .ToDictionary(entry => entry.Key, entry => entry.Value
                            .ToDictionary(innerEntry => innerEntry.Key, innerEntry => innerEntry.Key + "." + innerEntry.Value));
                }

                line = Console.ReadLine();
            }

            //foreach (var entry in dictionary)
            //{
            //    foreach (var innerEntry in entry.Value)
            //    {
            //        Console.WriteLine($"{entry.Key} => {innerEntry.Key}.{innerEntry.Value}");
            //    }
            //}

            dictionary
                .ToList()
                .ForEach(selector => selector.Value
                    .ToList()
                    .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}", 
                        selector.Key, 
                        selectorObject.Key, 
                        selectorObject.Value)));
        }
    }
}

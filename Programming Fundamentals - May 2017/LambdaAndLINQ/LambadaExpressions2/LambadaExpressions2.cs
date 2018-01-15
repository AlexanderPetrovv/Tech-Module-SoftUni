using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions2
{
    class LambadaExpressions2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (line != "lambada")
            {
                string[] tokens = line.Split(new string[] { " => ", "." }, StringSplitOptions.RemoveEmptyEntries);

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
                    var keys = dictionary.Keys.ToList();
                    foreach (var key in keys)
                    {
                        var innerKeys = dictionary[key].Keys.ToList();
                        foreach (var innerKey in innerKeys)
                        {
                            dictionary[key][innerKey] = innerKey + "." + dictionary[key][innerKey];
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var entry in dictionary)
            {
                string selector = entry.Key;
                Dictionary<string, string> innerDictionary = entry.Value;

                foreach (var innerEntry in innerDictionary)
                {
                    string selectorObject = innerEntry.Key;
                    string property = innerEntry.Value;

                    Console.WriteLine($"{selector} => {selectorObject}.{property}");
                }
            }

            //dictionary
            //    .ToList()
            //    .ForEach(selector => selector.Value
            //        .ToList()
            //        .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}",
            //            selector.Key,
            //            selectorObject.Key,
            //            selectorObject.Value)));
        }
    }
}

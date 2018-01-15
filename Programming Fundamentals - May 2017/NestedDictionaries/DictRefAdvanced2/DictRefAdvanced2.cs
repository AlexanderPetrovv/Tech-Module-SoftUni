using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRefAdvanced2
{
    class DictRefAdvanced2
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string currentKey = tokens[0];

                int firstValue = -1;

                if (int.TryParse(tokens[1], out firstValue))
                {
                    if (!data.ContainsKey(currentKey))
                    {
                        data[currentKey] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        data[currentKey].Add(int.Parse(tokens[i]));
                    }
                }
                else
                {
                    string otherKey = tokens[1];
                    if (data.ContainsKey(otherKey))
                    {
                        data[currentKey] = new List<int>(data[otherKey]);
                        //data[currentKey] = new List<int>();

                        //foreach (var value in data[currentKey])
                        //{
                        //    data[currentKey].Add(value);
                        //}
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var entry in data)
            {
                string name = entry.Key;
                List<int> numbers = entry.Value;
                Console.WriteLine("{0} === {1}", name, string.Join(", ", numbers));
            }
        }
    }
}

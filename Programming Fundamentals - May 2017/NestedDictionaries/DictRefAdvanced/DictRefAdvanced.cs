using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var result = new Dictionary<string, List<int>>();

            while (line != "end")
            {
                string[] input = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];

                if (IsName(input[1]))
                {
                    string otherName = input[1];

                    if (result.ContainsKey(otherName))
                    {
                        List<int> otherNameNumbers = result[otherName];

                        if (!result.ContainsKey(name))
                        {
                            result[name] = new List<int>();
                        }
                        result[name].Clear();
                        result[name].AddRange(otherNameNumbers);
                    }
                }
                else
                {
                    int[] nums = input[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();
                    }
                    result[name].AddRange(nums);
                }

                line = Console.ReadLine();
            }

            foreach (var person in result)
            {
                string name = person.Key;
                List<int> numbers = person.Value;

                Console.WriteLine($"{name} === {string.Join(", ", numbers)}");
            }
        }

        static bool IsName(string input)
        {
            foreach (char symbol in input)
            {
                if (char.IsLetter(symbol))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

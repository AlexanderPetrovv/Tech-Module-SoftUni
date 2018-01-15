using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_KeyValue_Value
{
    class KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            string targetKey = Console.ReadLine();
            string targetValue = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string key = line[0];
                string[] values = line[1].Split(';');

                FillDict(result, key, values);
            }

            PrintResult(targetKey, targetValue, result);
        }

        static void FillDict(Dictionary<string, List<string>> result, string key, string[] values)
        {
            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }

            foreach (string value in values)
            {
                result[key].Add(value);
            }
        }

        static void PrintResult(string targetKey, string targetValue, Dictionary<string, List<string>> result)
        {
            foreach (KeyValuePair<string, List<string>> pair in result)
            {
                string key = pair.Key;
                List<string> values = pair.Value;

                if (key.Contains(targetKey))
                {
                    Console.WriteLine($"{key}:");

                    foreach (string value in values)
                    {
                        if (value.Contains(targetValue))
                        {
                            Console.WriteLine($"-{value}");
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictRef
{
    class DictRef
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Dictionary<string, int> result = new Dictionary<string, int>();
            string name;
            string secondName;
            int value;
            while (line != "end")
            {
                string[] input = line.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
                name = input[0];
                var isParsed = int.TryParse(input[1], out value);

                if (isParsed)
                {
                    result[name] = value;
                }
                else
                {
                    secondName = input[1];
                    if (result.ContainsKey(secondName))
                    {
                        result[name] = result[secondName];
                    }
                }
                line = Console.ReadLine();
            }

            foreach (var nameValue in result)
            {
                Console.WriteLine($"{nameValue.Key} === {nameValue.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            string name;
            long number;
            bool isNumber;
            while (line != "Over")
            {
                string[] input = line.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                isNumber = long.TryParse(input[0], out number);
                if (isNumber)
                {
                    name = input[1];
                }
                else
                {
                    name = input[0];
                    number = long.Parse(input[1]);
                }

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                
                line = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> account in phonebook)
            {
                Console.WriteLine($"{account.Key} -> {account.Value}");
            }
        }
    }
}

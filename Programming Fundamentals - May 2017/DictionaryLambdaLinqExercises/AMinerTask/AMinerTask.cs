using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();              
                if (resource == "stop")
                {
                    break;
                }
                string quantity = Console.ReadLine();
                
                if (dict.ContainsKey(resource))
                {
                    dict[resource] += int.Parse(quantity);
                }
                else
                {
                    dict[resource] = int.Parse(quantity);
                }              
            }

            foreach (var resource in dict.Keys)
            {
                Console.WriteLine($"{resource} -> {dict[resource]}");
            }
        }
    }
}

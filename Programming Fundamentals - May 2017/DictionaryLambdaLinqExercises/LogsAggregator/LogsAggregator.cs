using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var nameDict = new SortedDictionary<string, SortedDictionary<string, int>>();
            int linesCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCnt; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                string ip = tokens[0];
                string name = tokens[1];
                int time = int.Parse(tokens[2]);

                if (!nameDict.ContainsKey(name))
                {
                    nameDict[name] = new SortedDictionary<string, int>();
                }

                if (!nameDict[name].ContainsKey(ip))
                {
                    nameDict[name][ip] = 0;
                }

                nameDict[name][ip] += time;
            }

            foreach (var item in nameDict)
            {
                string name = item.Key;
                var ipsTime = item.Value;

                int totalTime = ipsTime.Sum(x => x.Value);
                var ips = ipsTime.Select(ip => ip.Key).ToArray();

                Console.WriteLine($"{name}: {totalTime} [{string.Join(", ", ips)}]");
            }
        }
    }
}

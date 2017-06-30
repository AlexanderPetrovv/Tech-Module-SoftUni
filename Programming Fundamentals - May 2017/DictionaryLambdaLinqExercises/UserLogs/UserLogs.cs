using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var namesIps = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                FillDictionary(input, namesIps);         

                input = Console.ReadLine();
            }

            PrintUsersIpsCount(namesIps);

        }

        static void PrintUsersIpsCount(SortedDictionary<string, Dictionary<string, int>> namesIps)
        {
            foreach (var nameIps in namesIps)
            {
                string name = nameIps.Key;
                Dictionary<string, int> ipsCounts = nameIps.Value;

                Console.WriteLine($"{name}:");
                bool isFirstIp = true;
                foreach (var ipCounts in ipsCounts)
                {
                    int eachIpCnt = ipCounts.Value;
                    if (!isFirstIp)
                    {
                        Console.Write(", ");
                    }
                    Console.Write($"{ipCounts.Key} => {eachIpCnt}");
                    isFirstIp = false;
                }
                Console.WriteLine(".");
            }
        }

        static void FillDictionary(string input, SortedDictionary<string, Dictionary<string, int>> namesIps)
        {
            string username = input.Split('=').Last();
            string ipAdress = input.Split('=', ' ').Skip(1).First();

            if (!namesIps.ContainsKey(username))
            {
                namesIps[username] = new Dictionary<string, int>();
            }

            if (!namesIps[username].ContainsKey(ipAdress))
            {
                namesIps[username][ipAdress] = 0;
            }

            namesIps[username][ipAdress]++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodePhoenixOscarRomeoNovember
{
    class CodePhoenixOscarRomeoNovember
    {
        static void Main(string[] args)
        {
            var squads = new Dictionary<string, HashSet<string>>();

            string input;

            while ((input = Console.ReadLine()) != "Blaze it!")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string creature = tokens[0];
                string squadMate = tokens[1];

                if (!squads.ContainsKey(creature))
                {
                    squads[creature] = new HashSet<string>();
                }

                if (squadMate != creature)
                {
                    squads[creature].Add(squadMate);
                }
            }

            var filteredSquads = new Dictionary<string, int>();

            foreach (var squad in squads)
            {
                int cnt = 0;

                string creature = squad.Key;
                HashSet<string> squadMates = squad.Value;

                foreach (var squadMate in squadMates)
                {
                    if (!squads.ContainsKey(squadMate))
                    {
                        cnt++;
                    }
                    else
                    {
                        if (!squads[squadMate].Contains(creature))
                        {
                            cnt++;
                        }
                    }
                    filteredSquads[creature] = cnt;
                }
            }

            foreach (var filteredSquad in filteredSquads.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} : {1}", filteredSquad.Key, filteredSquad.Value);
            }           
        }
    }
}

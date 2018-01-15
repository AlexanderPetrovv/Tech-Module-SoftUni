using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var regionsShells = new Dictionary<string, HashSet<long>>();

            while (line != "Aggregate")
            {
                string[] input = line.Split(' ');
                string region = input[0];
                long shell = long.Parse(input[1]);

                if (!regionsShells.ContainsKey(region))
                {
                    regionsShells[region] = new HashSet<long>();
                }
                regionsShells[region].Add(shell);

                line = Console.ReadLine();
            }

            foreach (var regionShells in regionsShells)
            {
                string region = regionShells.Key;
                HashSet<long> shells = regionShells.Value;

                long giantShell = shells.Sum();
                if (shells.Count > 1)
                {
                    giantShell = shells.Sum() - (shells.Sum() / shells.Count);
                }

                Console.WriteLine($"{region} -> {string.Join(", ", shells)} ({giantShell})");
            }
        }
    }
}

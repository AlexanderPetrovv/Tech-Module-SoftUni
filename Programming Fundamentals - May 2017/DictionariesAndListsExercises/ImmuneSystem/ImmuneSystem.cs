using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            int remainingHealth = initialHealth;

            List<string> encounteredViruses = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string virusName = command;
                int virusStrength = 0;
                foreach (var letter in virusName.ToCharArray())
                {
                    virusStrength += letter;
                }
                virusStrength /= 3;
                var timeToDefeat = virusStrength * virusName.Count();
                if (!encounteredViruses.Contains(virusName))
                {
                    encounteredViruses.Add(virusName);
                    remainingHealth -= timeToDefeat;
                }
                else
                {
                    timeToDefeat /= 3;
                    remainingHealth -= timeToDefeat;
                }

                int timeToDefMins = timeToDefeat / 60;
                int timeToDefSec = timeToDefeat % 60;

                Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeat} seconds");
                if (remainingHealth >= 0)
                {
                    Console.WriteLine($"{virusName} defeated in {timeToDefMins}m {timeToDefSec}s.");
                    Console.WriteLine($"Remaining health: {remainingHealth}");
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                remainingHealth = (int)(remainingHealth * 1.2);
                if (remainingHealth > initialHealth)
                {
                    remainingHealth = initialHealth;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {remainingHealth}");
        }
    }
}

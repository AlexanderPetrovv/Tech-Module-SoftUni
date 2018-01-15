using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long hornetPower = hornets.Sum();

                if (hornets.Count != 0)
                {
                    long currentBeehive = beehives[i];

                    if (hornetPower > currentBeehive)
                    {
                        beehives.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        if (hornetPower == currentBeehive)
                        {
                            beehives.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            beehives[i] -= hornetPower;
                        }                      
                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    break;
                }
            }

            if (beehives.Count != 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}

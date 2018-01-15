using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            List<long> distance = Console.ReadLine().Split().Select(long.Parse).ToList();

            long totalValue = 0;

            while (distance.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                long elementValue = 0;               

                if (index < 0)
                {
                    elementValue = distance[0];
                    distance[0] = distance[distance.Count - 1];                    
                }
                else if (index > distance.Count - 1)
                {
                    elementValue = distance[distance.Count - 1];
                    distance[distance.Count - 1] = distance[0];                    
                }
                else
                {
                    elementValue = distance[index];
                    distance.RemoveAt(index);
                }
                totalValue += elementValue;

                for (int i = 0; i < distance.Count; i++)
                {
                    if (distance[i] <= elementValue)
                    {
                        distance[i] += elementValue;
                    }
                    else
                    {
                        distance[i] -= elementValue;
                    }
                }
            }

            Console.WriteLine(totalValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class DragonArmy
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                var input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];

                decimal damage = input[2] != "null" ? decimal.Parse(input[2]) : 45m;
                decimal health = input[3] != "null" ? decimal.Parse(input[3]) : 250m;
                decimal armor = input[4] != "null" ? decimal.Parse(input[4]) : 10m;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };
            }

            foreach (var type in dragons)
            {
                string typeName = type.Key;
                var dragonsByType = type.Value;

                decimal averageDamage = dragonsByType.Values.Average(a => a[0]);
                decimal averageHealth = dragonsByType.Values.Average(a => a[1]);
                decimal averageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonsByType)
                {
                    Console.WriteLine(
                        $"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}

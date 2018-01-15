using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }

                foreach (string cloth in clothes)
                {
                    if (!wardrobe[colour].ContainsKey(cloth))
                    {
                        wardrobe[colour].Add(cloth, 0);
                    }
                    wardrobe[colour][cloth]++;
                }
            }

            string[] target = Console.ReadLine().Split(' ');
            string targetColour = target[0];
            string targetCloth = target[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> coloursClothes in wardrobe)
            {
                string colour = coloursClothes.Key;
                Dictionary<string, int> clothesCount = coloursClothes.Value;

                Console.WriteLine($"{colour} clothes:");

                foreach (KeyValuePair<string, int> clothCount in clothesCount)
                {
                    string cloth = clothCount.Key;
                    int count = clothCount.Value;

                    Console.Write($"* {cloth} - {count}");
                    
                    if (colour == targetColour && cloth == targetCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

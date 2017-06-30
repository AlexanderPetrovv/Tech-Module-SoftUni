using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            var collectedMaterials = new Dictionary<string, int>();

            collectedMaterials["shards"] = 0;
            collectedMaterials["fragments"] = 0;
            collectedMaterials["motes"] = 0;

            string input = String.Empty;
            string keyItems = String.Empty;
            bool isCollected = false;

            while (!isCollected)
            {
                input = Console.ReadLine();
                var inputArr = input.ToLower().Split();

                for (int i = 0; i < inputArr.Length; i += 2)
                {
                    int quantity = int.Parse(inputArr[i]);
                    string material = inputArr[i + 1];

                    if (!collectedMaterials.ContainsKey(material))
                    {
                        collectedMaterials[material] = 0;
                    }
                    collectedMaterials[material] += quantity;

                    if (collectedMaterials[material] >= 250 && 
                        (material == "shards" || material == "fragments" || material == "motes"))
                    {
                        collectedMaterials[material] -= 250;
                        keyItems = material;
                        isCollected = true;
                        break;
                    }
                }
            }

            string legendary = String.Empty;
            switch (keyItems)
            {
                case "shards":
                    legendary = "Shadowmourne";
                    break;
                case "fragments":
                    legendary = "Valanyr";
                    break;
                case "motes":
                    legendary = "Dragonwrath";
                    break;
            }
            Console.WriteLine($"{legendary} obtained!");

            var sortedKeyMaterials = collectedMaterials.Take(3).OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            var sortedJunkMaterials = collectedMaterials.Skip(3).OrderBy(x => x.Key);

            foreach (var material in sortedKeyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in sortedJunkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper2
{
    class CottageScraper2
    {
        static void Main(string[] args)
        {
            var treesData = new List<KeyValuePair<string, int>>();

            string line = Console.ReadLine();

            while (line != "chop chop")
            {
                string[] tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string treeType = tokens[0];
                int treeHeight = int.Parse(tokens[1]);

                treesData.Add(new KeyValuePair<string, int>(treeType, treeHeight));

                line = Console.ReadLine();
            }

            string treeTypeToUse = Console.ReadLine();
            int minTreeHeight = int.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(treesData.Average(kvp => kvp.Value), 2);

            double usedLogsPrice = treesData
                .Where(kvp => kvp.Key == treeTypeToUse && kvp.Value >= minTreeHeight)
                .Sum(kvp => kvp.Value);

            double unusedLogsPrice = treesData
                .Where(kvp => kvp.Key != treeTypeToUse || kvp.Value < minTreeHeight)
                .Sum(kvp => kvp.Value);

            usedLogsPrice *= pricePerMeter;
            unusedLogsPrice *= pricePerMeter * 0.25;

            usedLogsPrice = Math.Round(usedLogsPrice, 2);
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);

            double totalPrice = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:F2}");
        }
    }
}

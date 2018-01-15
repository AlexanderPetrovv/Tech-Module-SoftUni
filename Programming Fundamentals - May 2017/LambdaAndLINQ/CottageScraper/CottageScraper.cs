using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var treesData = new Dictionary<string, List<int>>();

            while (line != "chop chop")
            {
                FillDictionary(line, treesData);

                line = Console.ReadLine();
            }

            string treeToUse = Console.ReadLine();
            int minTreeLength = int.Parse(Console.ReadLine());

            double pricePerMeter = CalcPricePerMeter(treesData);

            double usedLogsPrice = treesData
                .Where(x => x.Key == treeToUse)
                .SelectMany(x => x.Value)
                .Where(x => x >= minTreeLength)
                .Select(x => x * pricePerMeter)
                .Sum();

            var unusedLogsPrice = treesData
                .ToDictionary(x => x.Key != treeToUse, x => x.Value.Where(y => y < minTreeLength));

            foreach (var item in unusedLogsPrice)
            {
                foreach (var inner in item.Value)
                {
                    Console.WriteLine($"{inner} -> {item.Key}");
                }
            }
            //double unusedLogsPrice = treesData
            //    .Where(x => x.Value.(y => y < minTreeLength))
            //    .Where(x => x.Key != treeToUse)
            //    .SelectMany(x => x.Value)
            //    .Where(x => x < minTreeLength)
            //    .Select(x => x * pricePerMeter * 0.25)
            //    .Sum();

            Console.WriteLine(unusedLogsPrice);
        }

        static double CalcPricePerMeter(Dictionary<string, List<int>> treesData)
        {
            int totalLength = treesData.SelectMany(x => x.Value).Sum();
            int totalTrees = treesData.SelectMany(x => x.Value).Count();
            double pricePerMeter = Math.Round(((double)totalLength / totalTrees), 2);

            return pricePerMeter;
        }

        static void FillDictionary(string line, Dictionary<string, List<int>> treesData)
        {
            string[] tokens = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string treeType = tokens[0];
            int treeLength = int.Parse(tokens[1]);

            if (!treesData.ContainsKey(treeType))
            {
                treesData[treeType] = new List<int>();
            }
            treesData[treeType].Add(treeLength);
        }
    }
}

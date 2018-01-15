using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            /* A simpler way to check if combination of town and country exists */

            //var townsData = new SortedDictionary<string, SortedSet<string>>();
            var townsData = new HashSet<string>();

            AddTown(townsData, "Bulgaria", "Plovdiv");
            AddTown(townsData, "Austria", "Viena");
            AddTown(townsData, "Bulgaria", "Varna");
            AddTown(townsData, "Bulgaria", "Sofia");
            AddTown(townsData, "Austria", "Plovdiv");

            //foreach (var country in townsData.Keys)
            //{
            //    Console.WriteLine("{0} -> {1}", country, string.Join(", ", townsData[country]));
            //}

            Console.WriteLine(TownExist(townsData, "Bulgaria", "Sofia"));
            Console.WriteLine(TownExist(townsData, "Norway", "Sofia"));
            Console.WriteLine(TownExist(townsData, "Austria", "Sofia"));
            Console.WriteLine(TownExist(townsData, "Austria", "Plovdiv"));
            Console.WriteLine(TownExist(townsData, "Bulgaria", "Plovdiv"));
        }

        private static void AddTown(HashSet<string> townsData, string country, string town)
        {
            string key = CombineKeys(country, town);
            townsData.Add(key);
        }

        private static string CombineKeys(string country, string town)
        {
            return country + " | " + town;     // | - is a symbol separator which can't exist in county/town names
        }

        private static bool TownExist(HashSet<string> townsData, string country, string town)
        {
            string key = CombineKeys(country, town);          
            return townsData.Contains(key);           // Combining keys
        }

        //private static bool TownExist(SortedDictionary<string, SortedSet<string>> townsData, string country, string town)
        //{
        //    return (townsData.ContainsKey(country) && townsData[country].Contains(town));
        //}

        //private static void AddTown(SortedDictionary<string, SortedSet<string>> townsData, string country, string town)
        //{
        //    if (!townsData.ContainsKey(country))
        //    {
        //        townsData[country] = new SortedSet<string>();
        //    }
        //    townsData[country].Add(town);
        //}
    }
}

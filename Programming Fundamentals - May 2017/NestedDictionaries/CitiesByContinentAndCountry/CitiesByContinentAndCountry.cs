using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var geographyData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!geographyData.ContainsKey(continent))
                {
                    geographyData[continent] = new Dictionary<string, List<string>>();
                }

                if (!geographyData[continent].ContainsKey(country))
                {
                    geographyData[continent][country] = new List<string>();
                }

                geographyData[continent][country].Add(city);
            }

            foreach (var continentData in geographyData)
            {
                string continent = continentData.Key;
                var countriesData = continentData.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countryData in countriesData)
                {
                    string country = countryData.Key;
                    List<string> cities = countryData.Value;
                    Console.WriteLine($"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}

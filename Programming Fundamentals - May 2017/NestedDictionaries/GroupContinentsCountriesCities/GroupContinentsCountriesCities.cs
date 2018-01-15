using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupContinentsCountriesCities
{
    class GroupContinentsCountriesCities
    {
        static void Main(string[] args)
        {
            var geoData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!geoData.ContainsKey(continent))
                {
                    geoData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                }

                if (!geoData[continent].ContainsKey(country))
                {
                    geoData[continent].Add(country, new SortedSet<string>());
                }

                geoData[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continentData in geoData)
            {
                string continent = continentData.Key;
                SortedDictionary<string, SortedSet<string>> countries = continentData.Value;

                Console.WriteLine("{0}: ", continent);

                foreach (KeyValuePair<string, SortedSet<string>> countryData in countries)
                {
                    string country = countryData.Key;
                    SortedSet<string> cities = countryData.Value;

                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", cities));
                }
            }
        }
    }
}

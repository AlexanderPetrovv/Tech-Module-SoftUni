using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var countriesPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] inputArr = input.Split('|').ToArray();
                string city = inputArr[0];
                string country = inputArr[1];
                long cityPopulation = long.Parse(inputArr[2]);

                InsertCountry(countriesPopulation, country);
                InsertCityAndPopulation(countriesPopulation, country, city, cityPopulation);               

                input = Console.ReadLine();
            }

            PrintAggregatedData(countriesPopulation);
           
        }

        static void PrintAggregatedData(Dictionary<string, Dictionary<string, long>> countriesPopulation)
        {
            foreach (var country in countriesPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                string countryName = country.Key;
                long totalCountryPopulation = country.Value.Values.Sum();
                Console.WriteLine($"{countryName} (total population: {totalCountryPopulation})");
                foreach (var city in countriesPopulation[countryName].OrderByDescending(x => x.Value))
                {
                    string cityName = city.Key;
                    long cityPopulation = city.Value;
                    Console.WriteLine($"=>{cityName}: {cityPopulation}");
                }
            }
        }

        static void InsertCountry(Dictionary<string, Dictionary<string, long>> countriesPopulation, string country)
        {
            if (!countriesPopulation.ContainsKey(country))
            {
                countriesPopulation[country] = new Dictionary<string, long>();
            }
        }

        static void InsertCityAndPopulation(Dictionary<string, Dictionary<string, long>> countriesPopulation, string country, string city, long cityPopulation)
        {
            if (!countriesPopulation[country].ContainsKey(city))
            {
                countriesPopulation[country][city] = 0;
            }

            countriesPopulation[country][city] += cityPopulation;
        }
    }
}

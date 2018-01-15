using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nsa
{
    class Nsa
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            string pattern = @"^(?<country>[a-zA-Z\d]+)\s\-\>\s(?<spy>[a-zA-Z\d]+)\s\-\>\s(?<days>\d+)$";

            string input;

            while ((input = Console.ReadLine()) != "quit")
            {
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string country = match.Groups["country"].Value;
                    string spy = match.Groups["spy"].Value;
                    long days = long.Parse(match.Groups["days"].Value);

                    if (!data.ContainsKey(country))
                    {
                        data[country] = new Dictionary<string, long>();
                    }

                    if (!data[country].ContainsKey(spy))
                    {
                        data[country][spy] = 0;
                    }

                    data[country][spy] = days;
                }
            }

            foreach (var entry in data.OrderByDescending(x => x.Value.Count))
            {
                string country = entry.Key;
                var spies = entry.Value;

                Console.WriteLine("Country: {0}", country);

                foreach (var spy in spies.OrderByDescending(x => x.Value))
                {
                    string spyName = spy.Key;
                    long workingDays = spy.Value;

                    Console.WriteLine("**{0} : {1}", spyName, workingDays);
                }
            }
        }
    }
}

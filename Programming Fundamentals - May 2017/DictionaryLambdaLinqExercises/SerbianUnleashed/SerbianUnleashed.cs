using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            const string pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            var concerts = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(input, pattern);
                string singerName = match.Groups[1].Value;
                string venueName = match.Groups[2].Value;
                long ticketPrice = long.Parse(match.Groups[3].Value);
                long ticketCount = long.Parse(match.Groups[4].Value);

                long totalMoney = ticketPrice * ticketCount;

                if (!concerts.ContainsKey(venueName))
                {
                    concerts[venueName] = new Dictionary<string, long>();
                }

                if (!concerts[venueName].ContainsKey(singerName))
                {
                    concerts[venueName][singerName] = 0;
                }

                concerts[venueName][singerName] += totalMoney;

                input = Console.ReadLine();
            }

            foreach (var venue in concerts)
            {
                var venueName = venue.Key;
                Console.WriteLine(venueName);

                var sortedSingers = venue.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

                foreach (var singer in sortedSingers)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<symbols>\D+)(?<count>\d+)");

            string line = Console.ReadLine();

            Match match = pattern.Match(line);

            StringBuilder result = new StringBuilder();
            while (match.Success)
            {
                string symbols = match.Groups["symbols"].Value;
                int count = int.Parse(match.Groups["count"].Value);

                result.Append(BuildRageMessage(symbols, count));
                match = match.NextMatch();
            }

            int uniqueSymbolsCnt = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", uniqueSymbolsCnt);
            Console.WriteLine(result.ToString());
        }

        static string BuildRageMessage(string symbols, int count)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                builder.Append(symbols.ToUpper());
            }

            return builder.ToString();
        }
    }
}

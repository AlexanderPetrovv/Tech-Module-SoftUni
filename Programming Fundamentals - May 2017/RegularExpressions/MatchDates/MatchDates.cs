using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            // WE USE \1 BACKREFERENCE BECAUSE C# DOESN'T COUNT NAMED CAPTURED GROUPS FOR BACKREFERENCES, ELSE WE WOULD USE \2
            string datesInput = Console.ReadLine();

            MatchCollection dateMatches = Regex.Matches(datesInput, regex);

            foreach (Match date in dateMatches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

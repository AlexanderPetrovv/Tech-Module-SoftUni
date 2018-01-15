using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HappinessIndex2
{
    class HappinessIndex2
    {
        static void Main(string[] args)
        {
            const string pattern = @"((?<happy>[;:][)D*\]}]|[\(*c[][;:])|(?<sad>[;:][c([{]|[Dc\])][;:]))";

            Regex regex = new Regex(pattern);

            int happyCount = 0;
            int sadCount = 0;

            string line = Console.ReadLine();

            MatchCollection matches = regex.Matches(line);

            if(matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Group happy = match.Groups["happy"];
                    Group sad = match.Groups["sad"];

                    if (happy.Success)
                    {
                        happyCount++;
                    }
                    else if (sad.Success)
                    {
                        sadCount++;
                    }
                }
            }

            double happinessIndex = (double)happyCount / sadCount;
            string happinessScore = string.Empty;

            if (happinessIndex >= 2)
            {
                happinessScore = ":D";
            }
            else if (happinessIndex > 1)
            {
                happinessScore = ":)";
            }
            else if (happinessIndex == 1)
            {
                happinessScore = ":|";
            }
            else
            {
                happinessScore = ":(";
            }

            Console.WriteLine("Happiness index: {0:F2} {1}", happinessIndex, happinessScore);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happyCount, sadCount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballLeague2
{
    class Team
    {
        public int Points { get; set; }

        public int Goals { get; set; }

        public Team(int points, int goals)
        {
            this.Points = points;
            this.Goals = goals;
        }
    }

    class FootballLeague2
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Team>();

            string key = Console.ReadLine();

            string escapedKey = Regex.Escape(key);

            string pattern =
                string.Format(@"(?<={0})(?<teamA>[a-zA-Z]*)(?={0}).*(?<={0})(?<teamB>[a-zA-Z]*)(?={0})[^ ]* (?<scoreA>\d+):(?<scoreB>\d+)", escapedKey);

            Regex gameRegex = new Regex(pattern);

            string input;

            while ((input = Console.ReadLine()) != "final")
            {
                Match match = gameRegex.Match(input);

                string teamA = ReverseString(match.Groups["teamA"].Value).ToUpper();
                string teamB = ReverseString(match.Groups["teamB"].Value).ToUpper();
                int scoreA = int.Parse(match.Groups["scoreA"].Value);
                int scoreB = int.Parse(match.Groups["scoreB"].Value);

                if (!data.ContainsKey(teamA))
                {
                    data.Add(teamA, new Team(0, 0));
                }

                if (!data.ContainsKey(teamB))
                {
                    data.Add(teamB, new Team(0, 0));
                }

                data[teamA].Goals += scoreA;
                data[teamB].Goals += scoreB;

                if (scoreA > scoreB)
                {
                    data[teamA].Points += 3;
                }
                else if (scoreB > scoreA)
                {
                    data[teamB].Points += 3;
                }
                else if (scoreA == scoreB)
                {
                    data[teamA].Points += 1;
                    data[teamB].Points += 1;
                }
            }

            var standings = data.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key);

            var topThreeByGoals = data.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3);

            int standingsPos = 1;
            Console.WriteLine("League standings:");

            foreach (var teamData in standings)
            {
                string teamName = teamData.Key;
                Team team = teamData.Value;

                Console.WriteLine("{0}. {1} {2}", standingsPos, teamName, team.Points);
                standingsPos++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var teamData in topThreeByGoals)
            {
                string teamName = teamData.Key;
                Team team = teamData.Value;

                Console.WriteLine("- {0} -> {1}", teamName, team.Goals);
            }
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

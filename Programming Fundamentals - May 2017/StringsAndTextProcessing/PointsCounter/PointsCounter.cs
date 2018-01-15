using System;
using System.Collections.Generic;
using System.Linq;

namespace PointsCounter
{
    class PointsCounter
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var teams = new Dictionary<string, Dictionary<string, int>>();

            while (!line.Equals("Result"))
            {
                var prohibitedSymbols = new[] { "@", "%", "$", "*", "&" };
                line = ReplaceSymbols(line, prohibitedSymbols);

                string[] tokens = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                int points = int.Parse(tokens[2]);
                string player;
                string team;

                if (IsTeamName(tokens[0]))
                {
                    team = tokens[0];
                    player = tokens[1];
                }
                else
                {
                    player = tokens[0];
                    team = tokens[1];
                }

                FillDictionary(teams, points, player, team);

                line = Console.ReadLine();
            }

            PrintTeamsData(teams);
        }

        static string ReplaceSymbols(string line, string[] prohibitedSymbols)
        {
            foreach (string symbol in prohibitedSymbols)
            {
                line = line.Replace(symbol, "");
            }

            return line;
        }

        static bool IsTeamName(string input)
        {
            foreach (char letter in input)
            {
                if (!char.IsUpper(letter))
                {
                    return false;
                }
            }
            return true;
        }

        static void FillDictionary(Dictionary<string, Dictionary<string, int>> teams, int points, string player, string team)
        {
            if (!teams.ContainsKey(team))
            {
                teams[team] = new Dictionary<string, int>();
            }

            if (!teams[team].ContainsKey(player))
            {
                teams[team][player] = 0;
            }
            teams[team][player] = points;
        }

        static void PrintTeamsData(Dictionary<string, Dictionary<string, int>> teams)
        {
            var orderedTeams = teams.OrderByDescending(t => t.Value.Sum(p => p.Value));

            foreach (var team in orderedTeams)
            {
                string teamName = team.Key;
                int totalPoints = team.Value.Sum(p => p.Value);
                Console.WriteLine("{0} => {1}", teamName, totalPoints);

                string highestScorer = team.Value.OrderByDescending(p => p.Value).First().Key;
                Console.WriteLine("Most points scored by {0}", highestScorer);
            }
        }
    }
}

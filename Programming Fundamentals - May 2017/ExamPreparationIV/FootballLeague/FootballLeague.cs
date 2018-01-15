using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FootballLeague
{
    class FootballLeague
    {
        static Dictionary<string, long> teamGoals;

        static Dictionary<string, long> teamPoints;

        static void Main(string[] args)
        {
            string decryptionKey = Console.ReadLine();

            string line = Console.ReadLine();

            decryptionKey = Regex.Escape(decryptionKey);

            Regex regex = new Regex(decryptionKey + "(?<homeTeam>[a-zA-Z]*)" + decryptionKey + ".*" + 
                                    decryptionKey + "(?<awayTeam>[a-zA-Z]*)" + decryptionKey + @"[^ ]* (?<score>\d+:\d+)");

            teamGoals = new Dictionary<string, long>();
            teamPoints = new Dictionary<string, long>();

            while (line != "final")
            {
                if (regex.IsMatch(line))
                {
                    Match match = regex.Match(line);

                    string homeTeam = new string(match.Groups["homeTeam"].Value.Reverse().ToArray()).ToUpper();
                    string awayTeam = new string(match.Groups["awayTeam"].Value.Reverse().ToArray()).ToUpper();
                    string[] score = match.Groups["score"].Value.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    long homeTeamGoals = long.Parse(score[0]);
                    long awayTeamGoals = long.Parse(score[1]);

                    long homeTeamPoints = 0;
                    long awayTeamPoints = 0;

                    if (homeTeamGoals > awayTeamGoals)
                    {
                        homeTeamPoints = 3;
                    }
                    else if (awayTeamGoals > homeTeamGoals)
                    {
                        awayTeamPoints = 3;
                    }
                    else if (homeTeamGoals == awayTeamGoals)
                    {
                        homeTeamPoints = 1;
                        awayTeamPoints = 1;
                    }

                    FillGoalsAndPoints(homeTeam, homeTeamGoals, homeTeamPoints);

                    FillGoalsAndPoints(awayTeam, awayTeamGoals, awayTeamPoints);
                }

                line = Console.ReadLine();
            }

            PrintStandingsTable();

            PrintTopThreeMostScoringTeams();
        }

        static void PrintTopThreeMostScoringTeams()
        {
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                string teamName = team.Key;
                long goals = team.Value;
                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }

        static void PrintStandingsTable()
        {
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var team in teamPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string teamName = team.Key;
                long points = team.Value;
                Console.WriteLine($"{place}. {teamName} {points}");
                place++;
            }
        }

        private static void FillGoalsAndPoints(string teamName, long goals, long points)
        {
            if (!teamGoals.ContainsKey(teamName))
            {
                teamGoals[teamName] = 0;
                teamPoints[teamName] = 0;
            }
            teamGoals[teamName] += goals;
            teamPoints[teamName] += points;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace WormsWorldParty
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Dictionary<string, long>>();

            string input;

            while ((input = Console.ReadLine()) != "quit")
            {
                string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.None).Select(x => x.Trim()).ToArray();
                string teamName = tokens[1];
                string wormName = tokens[0];
                long wormScore = long.Parse(tokens[2].Trim());

                bool hasWorm = false;

                foreach (var team in teams)
                {
                    if (team.Value.ContainsKey(wormName))
                    {
                        hasWorm = true;
                    }
                }

                if (!hasWorm)
                {
                    if (!teams.ContainsKey(teamName))
                    {
                        teams[teamName] = new Dictionary<string, long>();
                    }
                    teams[teamName][wormName] = wormScore;
                }
            }

            teams = teams
            .OrderByDescending(x => x.Value.Sum(y => y.Value))
            .ThenByDescending(x => x.Value.Values.Average())
            .ToDictionary(x => x.Key, x => x.Value);

            int cnt = 1;
            foreach (var team in teams)
            {
                string teamName = team.Key;
                var worms = team.Value;
                long totalScore = worms.Sum(x => x.Value);

                Console.WriteLine("{0}. Team: {1} - {2}", cnt++, teamName, totalScore);

                foreach (var worm in worms.OrderByDescending(x => x.Value))
                {
                    string wormName = worm.Key;
                    long wormScore = worm.Value;

                    Console.WriteLine("###{0} : {1}", wormName, wormScore);
                }
            }
        }
    }
}

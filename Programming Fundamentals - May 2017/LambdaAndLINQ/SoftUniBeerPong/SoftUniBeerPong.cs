using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var teamsData = new Dictionary<string, Dictionary<string, long>>();

            while (line != "stop the game")
            {
                string[] tokens = line.Split('|');
                string player = tokens[0];
                string team = tokens[1];
                long pointsMade = long.Parse(tokens[2]);

                if (!teamsData.ContainsKey(team))
                {
                    teamsData[team] = new Dictionary<string, long>();
                }

                if (teamsData[team].Count() < 3)
                {
                    teamsData[team][player] = pointsMade;
                }

                line = Console.ReadLine();
            }

            int position = 1;
            foreach (var teamData in teamsData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                string team = teamData.Key;
                var playersPoints = teamData.Value;

                if (teamData.Value.Count() == 3)
                {
                    Console.WriteLine($"{position}. {team}; Players:");
                    foreach (var playerPoints in playersPoints.OrderByDescending(x => x.Value))
                    {
                        string player = playerPoints.Key;
                        long points = playerPoints.Value;
                        Console.WriteLine($"###{player}: {points}");
                    }
                    position++;
                }
            }
        }
    }
}

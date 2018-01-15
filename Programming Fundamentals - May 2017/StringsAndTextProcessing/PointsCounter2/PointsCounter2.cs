using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter2
{
    class Player
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override bool Equals(object obj)      // Allows us to use Contains() in List
        {
            if (obj is Player)  // Checks if obj is of type Player
            {
                Player other = (Player)obj;

                return this.Name == other.Name;
            }

            return false;
        }
    }

    class PointsCounter2
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Player>>();

            string line = Console.ReadLine();

            while (line != "Result")
            {
                string[] tokens = line.Split('|');

                string team;
                string player;
                int points = int.Parse(tokens[2]);
                
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

                team = CleanFromSymbols(team);
                player = CleanFromSymbols(player);

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new List<Player>());
                }

                Player currentPlayer = new Player(player, points);
                if (data[team].Contains(currentPlayer))
                {
                    int index = data[team].IndexOf(currentPlayer);
                    data[team][index].Points = points;
                }
                else
                {
                    data[team].Add(currentPlayer);
                }
                
                line = Console.ReadLine();
            }

            var orderedData = data.OrderByDescending(teamData => teamData.Value.Sum(p => p.Points));

            foreach (var teamData in orderedData)
            {
                string teamName = teamData.Key;
                List<Player> players = teamData.Value;
                int totalPoints = players.Sum(p => p.Points);
                Player bestPlayer = players.OrderByDescending(p => p.Points).First();

                Console.WriteLine("{0} => {1}", teamName, totalPoints);
                Console.WriteLine("Most points scored by {0}", bestPlayer.Name);
            }
        }

        static bool IsTeamName(string str)
        {
            return !str.Any(ch => char.IsLower(ch));
        }

        static string CleanFromSymbols(string str)
        {
            StringBuilder cleanStr = new StringBuilder();

            foreach (char ch in str)
            {
                if (!IsForbiddenSymbol(ch))
                {
                    cleanStr.Append(ch);
                }
            }
            return cleanStr.ToString();
        }

        static bool IsForbiddenSymbol(char ch)
        {
            return ch == '@' ||
                   ch == '%' ||
                   ch == '*' ||
                   ch == '$' ||
                   ch == '&';
        }
    }
}

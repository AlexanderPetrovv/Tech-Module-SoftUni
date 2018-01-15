using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }
    }

    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int teamsCnt = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            RegisterTeams(teams, teamsCnt);

            JoinTeams(teams);

            List<Team> regularTeams = teams.Where(t => t.Members.Count != 0).ToList();
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();

            PrintRegularTeams(regularTeams);
            PrintDisbandTeams(disbandTeams);
        }

        static void RegisterTeams(List<Team> teams, int teamsCnt)
        {
            for (int i = 0; i < teamsCnt; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split('-');
                string teamCreator = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else
                {
                    if (teams.Any(t => t.CreatorName == teamCreator))
                    {
                        Console.WriteLine($"{teamCreator} cannot create another team!");
                        continue;
                    }
                    else
                    {
                        Team team = new Team();
                        team.Name = teamName;
                        team.Members = new List<string>();
                        team.CreatorName = teamCreator;

                        Console.WriteLine($"Team {team.Name} has been created by {team.CreatorName}!");
                        teams.Add(team);
                        continue;
                    }
                }
            }
        }

        static void JoinTeams(List<Team> teams)
        {
            string line = Console.ReadLine();

            while (line != "end of assignment")
            {
                string[] tokens = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string memberToJoin = tokens[0];
                string teamToJoin = tokens[1];

                if (!teams.Any(t => t.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    if (teams.Any(team => team.CreatorName == memberToJoin)
                    || teams.Any(t => t.Members.Contains(memberToJoin)))
                    {
                        Console.WriteLine($"Member {memberToJoin} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        Team team = teams.First(t => t.Name == teamToJoin);
                        team.Members.Add(memberToJoin);
                    }
                }

                line = Console.ReadLine();
            }
        }

        static void PrintRegularTeams(List<Team> regularTeams)
        {
            foreach (Team team in regularTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (string member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        static void PrintDisbandTeams(List<Team> disbandTeams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams.OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}

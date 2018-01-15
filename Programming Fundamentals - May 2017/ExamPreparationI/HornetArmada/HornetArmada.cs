using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HornetArmada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legionsSoldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionsActivities = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                int soldierCount = int.Parse(tokens[3]);

                if (!legionsSoldiers.ContainsKey(legionName))
                {
                    legionsSoldiers.Add(legionName, new Dictionary<string, long>());
                    legionsActivities.Add(legionName, lastActivity);
                }

                if (!legionsSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsSoldiers[legionName].Add(soldierType, 0);
                }

                legionsSoldiers[legionName][soldierType] += soldierCount;
                if (lastActivity > legionsActivities[legionName])
                {
                    legionsActivities[legionName] = lastActivity;
                }
            }

            string finalLine = Console.ReadLine();
            Regex regex = new Regex(@"^(?<activity>\d+)\\(?<soldier>.*$)");
            if (regex.IsMatch(finalLine))
            {
                Match match = regex.Match(finalLine);

                int targetActivity = int.Parse(match.Groups["activity"].Value);
                string targetSoldier = match.Groups["soldier"].Value;

                foreach (var legionSoldiers in legionsSoldiers.Where(x => x.Value.ContainsKey(targetSoldier))
                    .OrderByDescending(x => x.Value[targetSoldier]))
                {
                    string legionName = legionSoldiers.Key;
                    var soldiers = legionSoldiers.Value;


                    if (targetActivity > legionsActivities[legionName])
                    {
                        Console.WriteLine("{0} -> {1}", legionName, legionsSoldiers[legionName][targetSoldier]);
                    }
                }
            }
            else
            {
                string targetSoldier = finalLine;

                foreach (var legionActivity in legionsActivities.OrderByDescending(x => x.Value))
                {
                    string legionName = legionActivity.Key;
                    int activity = legionActivity.Value;

                    if (legionsSoldiers[legionName].ContainsKey(targetSoldier))
                    {
                        Console.WriteLine($"{activity} : {legionName}");
                    }
                }
            }
        }
    }
}

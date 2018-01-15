using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainers
{
    class Trainers
    {
        static void Main(string[] args)
        {
            var teamsData = new Dictionary<string, double>
            {
                { "Technical", 0 },
                { "Theoretical", 0 },
                { "Practical", 0 }
            };

            int participants = int.Parse(Console.ReadLine());

            for (int i = 0; i < participants; i++)
            {
                long travelDistanceInMiles = long.Parse(Console.ReadLine());
                double cargoTons = double.Parse(Console.ReadLine());
                string participantTeam = Console.ReadLine();

                long distanceInMeters = travelDistanceInMiles * 1600;
                double cargoKg = cargoTons * 1000;

                double participantEarnedMoney = (cargoKg * 1.5) - (0.7 * distanceInMeters * 2.5);
                
                teamsData[participantTeam] += participantEarnedMoney;
            }

            var winner = teamsData.OrderByDescending(x => x.Value).First();

            Console.WriteLine($"The {winner.Key} Trainers win with ${winner.Value:f3}.");
        }
    }
}

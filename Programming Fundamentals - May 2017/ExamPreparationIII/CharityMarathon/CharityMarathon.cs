using System;

namespace CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int durationInDays = int.Parse(Console.ReadLine());

            long numberOfRunners = long.Parse(Console.ReadLine());

            int averageLapsPerRunner = int.Parse(Console.ReadLine());

            long trackLength = long.Parse(Console.ReadLine());

            int trackCapacity = int.Parse(Console.ReadLine());

            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            // SOLUTION:

            int maxRunners = durationInDays * trackCapacity;

            if (maxRunners < numberOfRunners)
            {
                numberOfRunners = maxRunners;
            }

            long totalMeters = numberOfRunners * averageLapsPerRunner * trackLength;
            long totalKm = totalMeters / 1000;
            decimal moneyForMarathon = moneyPerKm * totalKm;

            Console.WriteLine("Money raised: {0:F2}", moneyForMarathon);
        }
    }
}

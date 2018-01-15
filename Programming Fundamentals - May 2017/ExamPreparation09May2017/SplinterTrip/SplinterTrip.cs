using System;

namespace SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());     // NOTE: Distance is in miles
            double tankCapacity = double.Parse(Console.ReadLine());  // NOTE: Capacity in liters
            double heavyWindDistance = double.Parse(Console.ReadLine());   // NOTE: Heavy wind distance in miles

            double normalConsumption = (distance - heavyWindDistance) * 25;
            double heavyWindConsumption = heavyWindDistance * 25 * 1.5;

            double fuelConsumption = normalConsumption + heavyWindConsumption;
            double tolerance = fuelConsumption * 0.05;
            double totalFuelConsumption = fuelConsumption + tolerance;

            double remainingFuel = tankCapacity - totalFuelConsumption;

            Console.WriteLine("Fuel needed: {0:f2}L", totalFuelConsumption);
            
            if (remainingFuel < 0)
            {
                Console.WriteLine("We need {0:f2}L more fuel.", Math.Abs(remainingFuel));
            }
            else
            {
                Console.WriteLine("Enough with {0:f2}L to spare!", remainingFuel);
            }
        }
    }
}

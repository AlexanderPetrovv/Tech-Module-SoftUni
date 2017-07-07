using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] batteryUsage = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());

            double[] totalUsage = new double[batteryUsage.Length];
            int[] hoursPerBattery = new int[batteryUsage.Length];

            for (int h = 1; h <= hours; h++)
            {
                for (int i = 0; i < capacities.Length; i++)
                {
                    if(capacities[i] > totalUsage[i])
                    {
                        totalUsage[i] += batteryUsage[i];
                        hoursPerBattery[i]++;
                    }
                }
            }

            for (int i = 0; i < capacities.Length; i++)
            {
                int batteryNumber = i + 1;             
                if (totalUsage[i] >= capacities[i])
                {
                    int hoursLasted = hoursPerBattery[i];
                    Console.WriteLine($"Battery {batteryNumber}: dead (lasted {hoursLasted} hours)");
                }
                else
                {
                    double batteryStatus = capacities[i] - totalUsage[i];
                    double percentsLeft = batteryStatus / capacities[i] * 100;
                    Console.WriteLine($"Battery {batteryNumber}: {batteryStatus:F2} mAh ({percentsLeft:F2})%");
                }
            }
        }
    }
}

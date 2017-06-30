using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You have a water tank with capacity of 255 liters.
On the next n lines, you will receive liters of water, which you have to pour in your tank.
If the capacity is not enough, print “Insufficient capacity!” and continue reading the next line.
On the last line, print the liters in the tank.
 */

namespace WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());
            byte waterTankCapacity = byte.MaxValue;
            int waterSoFar = 0;
            for (int i = 0; i < inputCnt; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                waterSoFar += quantity;

                if (waterSoFar > waterTankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterSoFar -= quantity;
                    continue;
                }
            }
            Console.WriteLine(waterSoFar);
        }
    }
}

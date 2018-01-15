using System;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double thousandFlapsDistance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());  // How many wing flaps he can make before he stops to take a break.

            int restTime = 5; // Rest time is equal to 5 sec.
            int wingFlapsPerSecond = 100;

            double distance = (wingFlaps / 1000) * thousandFlapsDistance;
            double flapTime = wingFlaps / 100;
            double totalRestTime = (wingFlaps / endurance) * restTime;
            double totalTime = flapTime + totalRestTime;

            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", totalTime);
        }
    }
}

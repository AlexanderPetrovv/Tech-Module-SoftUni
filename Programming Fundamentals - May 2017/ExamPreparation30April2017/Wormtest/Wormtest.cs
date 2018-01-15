using System;

namespace Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            int wormLength = int.Parse(Console.ReadLine()); // Worm's length in meters.
            double wormWidth = double.Parse(Console.ReadLine()); // Worm's width in centimeters.

            int wormLengthInCent = wormLength * 100;

            if (wormWidth == 0 || (int)(wormLengthInCent % wormWidth) == 0)
            {
                Console.WriteLine("{0:f2}", wormLengthInCent * wormWidth);
            }
            else
            {
                Console.WriteLine("{0:f2}%", wormLengthInCent / wormWidth * 100);
            }
        }
    }
}

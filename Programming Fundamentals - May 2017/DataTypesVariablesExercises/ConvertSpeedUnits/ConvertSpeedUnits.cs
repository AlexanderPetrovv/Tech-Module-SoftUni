using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTimeSec = (hours * 3600) + (minutes * 60) + seconds;
            float meterPerSec = (float)meters / totalTimeSec;
            float kmPerHr = ((float)meters / 1000) / ((float)totalTimeSec / 3600);
            float miPerHr = ((float)meters / 1609) / ((float)totalTimeSec / 3600);

            Console.WriteLine(meterPerSec);
            Console.WriteLine(kmPerHr);
            Console.WriteLine(miPerHr);

        }
    }
}

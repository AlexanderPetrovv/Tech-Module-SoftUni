using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            var beatsPerMin = double.Parse(Console.ReadLine());
            var beatNumber = double.Parse(Console.ReadLine());

            var bars = Math.Round(beatNumber / 4.0, 1);
            var secPerBeat = 60 / beatsPerMin;

            var totalSec = secPerBeat * beatNumber;
            var minutes = (int)totalSec / 60;
            var seconds = (int)totalSec % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}

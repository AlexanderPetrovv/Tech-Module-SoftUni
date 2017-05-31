using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var mileToKm = 1.60934;
            var result = input * mileToKm;
            Console.WriteLine($"{result:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var productVolume = int.Parse(Console.ReadLine());
            var energyContent100Ml = int.Parse(Console.ReadLine());
            var sugarContent100Ml = int.Parse(Console.ReadLine());

            var totalEnergy = productVolume * energyContent100Ml / 100.0;
            var totalSugar = productVolume * sugarContent100Ml / 100.0;

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}

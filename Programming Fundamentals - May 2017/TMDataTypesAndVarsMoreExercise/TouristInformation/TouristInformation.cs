using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program, which helps tourists convert imperial units of measurement to metric units.
Your program needs to support the following conversions:
miles to kilometers, inches to centimeters, feet to centimeters, yards to meters and gallons to liters.
*/

namespace TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            string convertUnit = null;
            double convertValue = 0;
            switch (unit)
            {
                case "miles":
                    convertUnit = "kilometers";
                    convertValue = value * 1.6;
                    break;
                case "inches":
                    convertUnit = "centimeters";
                    convertValue = value * 2.54;
                    break;
                case "feet":
                    convertUnit = "centimeters";
                    convertValue = value * 30;
                    break;
                case "yards":
                    convertUnit = "meters";
                    convertValue = value * 0.91;
                    break;
                case "gallons":
                    convertUnit = "liters";
                    convertValue = value * 3.8;
                    break;
            }

            Console.WriteLine($"{value} {unit} = {convertValue:F2} {convertUnit}");
        }
    }
}

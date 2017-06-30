using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCnt = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.0;
                    doublePrice = 65.0;
                    suitePrice = 75.0;
         
                    if (nightsCnt > 7)
                    {
                        studioPrice = studioPrice * 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60.0;
                    doublePrice = 72.0;
                    suitePrice = 82.0;

                    if (nightsCnt > 14)
                    {
                        doublePrice = doublePrice * 0.9;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68.0;
                    doublePrice = 77.0;
                    suitePrice = 89.0;

                    if (nightsCnt > 14)
                    {
                        suitePrice = suitePrice * 0.85;
                    }
                    break;
            }

            var totalStudioPrice = studioPrice * nightsCnt;
            var totalDoublePrice = doublePrice * nightsCnt;
            var totalSuitePrice = suitePrice * nightsCnt;

            if ((month == "September" || month == "October") && nightsCnt > 7)
            {
                totalStudioPrice -= studioPrice;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");
        }
    }
}

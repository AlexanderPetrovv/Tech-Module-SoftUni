using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("BG-bg");
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);           
            Console.WriteLine(date.DayOfWeek);

            //int[] dateInput = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            //int day = dateInput[0];
            //int month = dateInput[1];
            //int year = dateInput[2];

            //var date = new DateTime(year, month, day);
            //Console.WriteLine(date.DayOfWeek);
        }
    }
}

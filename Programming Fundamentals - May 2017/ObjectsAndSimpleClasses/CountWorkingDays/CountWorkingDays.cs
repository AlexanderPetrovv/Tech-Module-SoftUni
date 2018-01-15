using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2017, 1, 1),
                new DateTime(2017, 3, 3),
                new DateTime(2017, 5, 1),
                new DateTime(2017, 5, 6),
                new DateTime(2017, 5, 24),
                new DateTime(2017, 9, 6),
                new DateTime(2017, 9, 22),
                new DateTime(2017, 11, 1),
                new DateTime(2017, 12, 24),
                new DateTime(2017, 12, 25),
                new DateTime(2017, 12, 26)
            };

            int count = 0;
            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1))
            {
                // Any uses short circuit algorithm and breaks as soon as element satisfies the condition
                var isWeekend = current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday;
                var isHoliday = holidays.Any(date => date.Day == current.Day && date.Month == current.Month);
                var isWorkingDay = !(isHoliday || isWeekend);
                if (isWorkingDay)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

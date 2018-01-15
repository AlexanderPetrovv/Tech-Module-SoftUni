using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays2
{
    class CountWorkingDays2
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = GetAllHolidays();

            int workingDays = 0;
            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1))
            {
                DateTime newDate = new DateTime(2000, current.Month, current.Day);
                if (!holidays.Contains(newDate) 
                    && current.DayOfWeek != DayOfWeek.Saturday 
                    && current.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);
        }

        static DateTime[] GetAllHolidays()
        {
            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2000, 1, 1),
                new DateTime(2000, 3, 3),
                new DateTime(2000, 5, 1),
                new DateTime(2000, 5, 6),
                new DateTime(2000, 5, 24),
                new DateTime(2000, 9, 6),
                new DateTime(2000, 9, 22),
                new DateTime(2000, 11, 1),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26)
            };
            return holidays;
        }
    }
}

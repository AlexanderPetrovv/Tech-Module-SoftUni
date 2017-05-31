using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var addTime = 30;

            //var totalMin = hours * 60 + minutes + addTime;
            //hours = totalMin / 60;
            //minutes = totalMin % 60;

            //if (hours >= 24)
            //{
            //    hours = hours % 24;
            //}

            //Console.WriteLine($"{hours}:{minutes:00}");

            minutes += addTime;
            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            if (minutes <= 9)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}

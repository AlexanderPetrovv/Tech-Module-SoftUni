using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var cheeseCnt = 0;
            var tomatoCnt = 0;
            var salamiCnt = 0;
            var pepperCnt = 0;

            for (int i = 1; i <= n; i++)
            {
                var ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese")
                    cheeseCnt++;
                else if (ingredient == "tomato sauce")
                    tomatoCnt++;
                else if (ingredient == "salami")
                    salamiCnt++;
                else if (ingredient == "pepper")
                    pepperCnt++;
            }

            var cheeseCal = cheeseCnt * 500;
            var tomatoCal = tomatoCnt * 150;
            var salamiCal = salamiCnt * 600;
            var pepperCal = pepperCnt * 50;

            Console.WriteLine($"Total calories: {cheeseCal + tomatoCal + salamiCal + pepperCal}");
        }
    }
}

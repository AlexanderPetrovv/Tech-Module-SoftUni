using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hall = "";
            var hallPrice = 0.0;
            var packagePrice = 0.0;
            var afterDiscount = 0.0;
            var pricePerPerson = 0.0;

            switch (package.ToLower())
            {
                case "normal": packagePrice = 500; afterDiscount = 0.95; break;
                case "gold": packagePrice = 750; afterDiscount = 0.9; break;
                case "platinum": packagePrice = 1000; afterDiscount = 0.85; break;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    hallPrice = 2500;
                }
                else if (groupSize <= 100)
                {
                    hall = "Terrace";
                    hallPrice = 5000;
                }
                else if (groupSize <= 120)
                {
                    hall = "Great Hall";
                    hallPrice = 7500;
                }

                pricePerPerson = ((hallPrice + packagePrice) * afterDiscount) / groupSize;

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}

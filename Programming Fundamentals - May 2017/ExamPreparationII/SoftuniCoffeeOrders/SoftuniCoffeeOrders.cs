using System;
using System.Globalization;

namespace SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            int ordersCnt = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;
            for (int i = 0; i < ordersCnt; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCnt = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal orderPrice = daysInMonth * capsulesCnt * pricePerCapsule;
                Console.WriteLine("The price for the coffee is: ${0:f2}", orderPrice);

                totalPrice += orderPrice;
            }
            Console.WriteLine("Total: ${0:f2}", totalPrice);
        }
    }
}

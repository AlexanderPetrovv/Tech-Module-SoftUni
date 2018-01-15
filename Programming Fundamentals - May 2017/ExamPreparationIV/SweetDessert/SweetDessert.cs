using System;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal pricePerPortion = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            int dishesPerPortion = 6;
            int totalPortions = guests / dishesPerPortion + 1;
            if (guests % dishesPerPortion == 0)
            {
                totalPortions = guests / dishesPerPortion;
            }
            decimal totalPrice = totalPortions * pricePerPortion;

            if (cash >= totalPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", totalPrice - cash);
            }
        }
    }
}

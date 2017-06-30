using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are assigned to rework a given piece of code which is working without bugs but is not properly formatted.
The given program tracks stock prices and gives updates about the significance in each price change.
Based on the significance, there are four kind of changes:
no change at all (price is equal to the previous), minor (difference is below the significance threshold), price up and price down.
*/

namespace PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double priceChangeSignificance = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double diff = CalcDifference(lastPrice, price);
                bool isSignificantDifference = CheckForSignificantDiff(diff, priceChangeSignificance);
                string priceChangeMessage = PrintPriceChangeSignificance(price, lastPrice, diff, isSignificantDifference);
                Console.WriteLine(priceChangeMessage);
                lastPrice = price;
            }
        }

        private static string PrintPriceChangeSignificance(
            double price, double lastPrice, double diff, bool isSignificantDifference)
        {
            string message = "";
            if (diff == 0)
            {
                message = string.Format("NO CHANGE: {0}", price);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, diff * 100);
            }
            else if (isSignificantDifference && (diff > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, diff * 100);
            }
            else if (isSignificantDifference && (diff < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, diff * 100);
            }
            return message;
        }

        private static bool CheckForSignificantDiff(double diff, double priceChangeSignificance)
        {
            if (Math.Abs(diff) >= Math.Abs(priceChangeSignificance))
            {
                return true;
            }
            return false;
        }

        private static double CalcDifference(double lastPrice, double price)
        {
            double diff = (price - lastPrice) / lastPrice;
            return diff;
        }
    }
}
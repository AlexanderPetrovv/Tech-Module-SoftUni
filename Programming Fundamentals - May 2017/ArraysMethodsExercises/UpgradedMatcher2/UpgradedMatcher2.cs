using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedMatcher2
{
    class UpgradedMatcher2
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            long[] adjustedQuantity = new long[products.Length];    // We make all the arrays equal size
            for (int i = 0; i < quantities.Length; i++)         // We take shorter array and copy its values in longer adjusted one
            {
                adjustedQuantity[i] = quantities[i];
            }

            long quantityNeeded = 0;
            string command = Console.ReadLine();
            
            while(command != "done")
            {
                string[] cmd = command.Split();
                int index = Array.IndexOf(products, cmd[0]);
                quantityNeeded = long.Parse(cmd[1]);

                if (adjustedQuantity[index] >= quantityNeeded)
                {
                    adjustedQuantity[index] -= quantityNeeded;
                    Console.WriteLine($"{products[index]} x {cmd[1]} costs {(prices[index] * quantityNeeded):f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                command = Console.ReadLine();
            }
        }
    }
}

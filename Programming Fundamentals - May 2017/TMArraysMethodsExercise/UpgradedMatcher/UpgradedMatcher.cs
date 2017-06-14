using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            long quantity = 0;
            string command = Console.ReadLine();
            while (command != "done")
            {
                string[] cmd = command.Split();
                quantity = long.Parse(cmd[1]);
                int index = Array.IndexOf(products, cmd[0]);
                if (index <= quantities.Length - 1 && quantities[index] >= quantity)
                {
                    quantities[index] -= quantity;
                    Console.WriteLine($"{products[index]} x {cmd[1]} costs {(prices[index] * quantity):f2}");
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

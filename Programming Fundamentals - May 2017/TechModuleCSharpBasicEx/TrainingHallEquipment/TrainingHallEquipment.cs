using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var items = int.Parse(Console.ReadLine());

            var itemName = "";
            var itemPrice = 0.0;
            var itemCnt = 0;
            var totalSpent = 0.0;

            for (int i = 0; i < items; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCnt = int.Parse(Console.ReadLine());

                if (itemCnt > 1)
                {
                    Console.WriteLine($"Adding {itemCnt} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCnt} {itemName} to cart.");
                }

                totalSpent += itemPrice * itemCnt;
            }

            Console.WriteLine($"Subtotal: ${totalSpent:f2}");
            if (totalSpent > budget)
            {
                Console.WriteLine($"Not enough. We need ${(totalSpent - budget):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${(budget - totalSpent):f2}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            FillInventory(inventory, line);

            BuyProducts(inventory, line);

            foreach (KeyValuePair<string, int> item in inventory)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }

        static void BuyProducts(Dictionary<string, int> inventory, string line)
        {
            string product;
            int buyQuantity;
            while (line != "exam time")
            {
                if (line.Contains("buy"))
                {
                    string[] input = line.Split(' ');
                    product = input[1];
                    buyQuantity = int.Parse(input[2]);

                    if (!inventory.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                    else if (inventory[product] <= 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else if (inventory[product] <= buyQuantity)
                    {
                        inventory[product] = 0;
                    }
                    else
                    {
                        inventory[product] -= buyQuantity;
                    }
                }

                line = Console.ReadLine();
            }
        }

        static void FillInventory(Dictionary<string, int> inventory, string line)
        {
            string product;
            int quantity;
            while (line != "shopping time")
            {
                if (line.Contains("stock"))
                {
                    string[] input = line.Split(' ');
                    product = input[1];
                    quantity = int.Parse(input[2]);

                    if (!inventory.ContainsKey(product))
                    {
                        inventory.Add(product, 0);
                    }
                    inventory[product] += quantity;
                }

                line = Console.ReadLine();
            }
        }
    }
}

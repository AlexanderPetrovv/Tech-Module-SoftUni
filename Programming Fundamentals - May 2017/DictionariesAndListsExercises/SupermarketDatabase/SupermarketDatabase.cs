using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            string productData = Console.ReadLine();

            var productsPrices = new Dictionary<string, decimal>();
            var productsQuantities = new Dictionary<string, long>();

            while(productData != "stocked")
            {
                string[] products = productData.Split(' ').ToArray();
                string productName = products[0];
                decimal price = decimal.Parse(products[1]);
                long quantity = int.Parse(products[2]);

                if (!productsQuantities.ContainsKey(productName))
                {
                    productsQuantities[productName] = 0;
                }

                productsQuantities[productName] += quantity;
                productsPrices[productName] = price;

                productData = Console.ReadLine();
            }

            decimal grandTotal = 0m;
            foreach (var productPrice in productsPrices)
            {
                decimal price = productPrice.Value;

                foreach (var productQuantities in productsQuantities)
                {
                    string name = productQuantities.Key;
                    long quantity = productQuantities.Value;

                    if (productPrice.Key == productQuantities.Key)
                    {
                        var totalProductPrice = price * quantity;
                        grandTotal += totalProductPrice;

                        Console.WriteLine($"{name}: ${price:F2} * {quantity} = ${totalProductPrice:F2}");
                    }
                }
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}

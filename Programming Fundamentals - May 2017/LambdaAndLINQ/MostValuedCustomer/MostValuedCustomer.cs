using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class MostValuedCustomer
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var shopPrices = new Dictionary<string, decimal>();

            while (line != "Shop is open")
            {
                FillDictionaryShopPrices(line, shopPrices);
                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            var customersSpendings = new Dictionary<string, List<string>>();

            while (line != "Print")
            {
                if (line != "Discount")
                {
                    FillDictionaryCustomersSpendings(line, shopPrices, customersSpendings);
                }
                else
                {
                    DiscountProducts(shopPrices);
                }
                line = Console.ReadLine();
            }

            PrintMostValuableCustomerData(shopPrices, customersSpendings);
        }

        static void PrintMostValuableCustomerData(Dictionary<string, decimal> shopPrices,
            Dictionary<string, List<string>> customersSpendings)
        {
            KeyValuePair<string, List<string>> mvc = GetMostValuableCustomer(shopPrices, customersSpendings);

            string name = mvc.Key;
            List<string> purchases = mvc.Value;
            Console.WriteLine($"Biggest spender: {name}");
            Console.WriteLine($"^Products bought:");

            decimal total = purchases.Sum(x => shopPrices[x]);
            var orderedProducts = purchases.Distinct().OrderByDescending(x => shopPrices[x]);
            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"^^^{product}: {shopPrices[product]:F2}");
            }
            Console.WriteLine($"Total: {total:F2}");
        }

        static KeyValuePair<string, List<string>> GetMostValuableCustomer(Dictionary<string, decimal> shopPrices, 
            Dictionary<string, List<string>> customersSpendings)
        {
            return customersSpendings.OrderByDescending(x => x.Value.Sum(product => shopPrices[product])).First();
        }

        static void DiscountProducts(Dictionary<string, decimal> shopPrices)
        {
            var discountProducts = shopPrices
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(x => new KeyValuePair<string, decimal>(x.Key, x.Value * 0.9m));

            foreach (var dp in discountProducts)
            {
                shopPrices[dp.Key] = dp.Value;
            }
        }

        static void FillDictionaryCustomersSpendings(string line, Dictionary<string, decimal> shopPrices, Dictionary<string, List<string>> customersSpendings)
        {
            string[] tokens = line.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
            string customerName = tokens[0];
            List<string> products = tokens[1]
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (!customersSpendings.ContainsKey(customerName))
            {
                customersSpendings[customerName] = new List<string>();
            }

            for (int i = 0; i < products.Count; i++)
            {
                string currentProduct = products[i];
                if (shopPrices.ContainsKey(currentProduct))
                {
                    customersSpendings[customerName].Add(currentProduct);
                }
            }
        }

        static void FillDictionaryShopPrices(string line, Dictionary<string, decimal> shopPrices)
        {
            string[] tokens = line.Split(' ');
            string product = tokens[0];
            decimal price = decimal.Parse(tokens[1]);

            shopPrices[product] = price;
        }
    }
}

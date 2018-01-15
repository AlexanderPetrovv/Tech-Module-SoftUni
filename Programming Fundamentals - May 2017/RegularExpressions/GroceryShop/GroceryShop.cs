using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GroceryShop
{
    class GroceryShop
    {
        static void Main(string[] args)
        {
            var productsPrices = new Dictionary<string, decimal>();

            string regex = @"^[A-Z][a-z]+:\d+\.\d{2}$";
            string input = Console.ReadLine();

            while (input != "bill")
            {
                if (Regex.IsMatch(input, regex))
                {
                    string[] productTokens = input.Split(':').ToArray();
                    string product = productTokens[0];
                    decimal price = decimal.Parse(productTokens[1]);

                    if (!productsPrices.ContainsKey(product))
                    {
                        productsPrices.Add(product, price);
                    }
                    else
                    {
                        productsPrices[product] = price;
                    }                   
                }

                input = Console.ReadLine();
            }

            foreach (var productPrice in productsPrices.OrderByDescending(x => x.Value))
            {
                string product = productPrice.Key;
                decimal price = productPrice.Value;

                Console.WriteLine($"{product} costs {price:F2}");
            }
        }
    }
}

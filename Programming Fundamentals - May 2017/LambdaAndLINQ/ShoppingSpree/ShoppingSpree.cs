using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            var productsPrices = new Dictionary<string, decimal>();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');
                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (productsPrices.ContainsKey(product))
                {
                    if (productsPrices[product] > price)
                    {
                        productsPrices[product] = price;
                    }
                }
                else
                {
                    productsPrices[product] = price;
                }

                line = Console.ReadLine();
            }
            
            if (productsPrices.Values.Sum() > budget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                productsPrices
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key.Length)
                    .Select(x => x.Key + " costs " + String.Format("{0:0.00}", x.Value))
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}

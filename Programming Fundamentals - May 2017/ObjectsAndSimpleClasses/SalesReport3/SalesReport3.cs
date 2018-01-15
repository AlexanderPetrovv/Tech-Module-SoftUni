using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport3
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale Parse(string inputLine)
        {
            string[] inputArr = inputLine.Split(' ');
            return new Sale()
            {
                Town = inputArr[0],
                Product = inputArr[1],
                Price = decimal.Parse(inputArr[2]),
                Quantity = decimal.Parse(inputArr[3])
            };
        }
    }

    class SalesReport3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = Sale.Parse(Console.ReadLine());

                if (!sales.ContainsKey(currentSale.Town))
                {
                    sales[currentSale.Town] = 0;
                }
                sales[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
            }
        }
    }
}

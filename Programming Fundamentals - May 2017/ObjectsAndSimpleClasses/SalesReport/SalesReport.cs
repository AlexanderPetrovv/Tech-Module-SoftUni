using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class SalesReport
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

        class SalesByCity
        {
            public string Town { get; set; }
            public decimal Sales { get; set; }
        }

        static void Main(string[] args)
        {
            var sales = ReadSales();
            var salesByCity = CalcSalesByCity(sales);

            foreach (var s in salesByCity)
            {
                Console.WriteLine($"{s.Town} -> {s.Sales:F2}");
            }
        }

        static List<Sale> ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var currentSale = ReadSale();
                sales.Add(currentSale);
            }
            return sales;
        }

        static Sale ReadSale()
        {
            string[] inputSale = Console.ReadLine().Split(' ').ToArray();
            return new Sale
            {
                Town = inputSale[0],
                Product = inputSale[1],
                Price = decimal.Parse(inputSale[2]),
                Quantity = decimal.Parse(inputSale[3])
            };
        }

        static List<SalesByCity> CalcSalesByCity(List<Sale> sales)
        {
            var salesByCity = new SortedDictionary<string, decimal>();
            foreach (var sale in sales)
            {
                if (!salesByCity.ContainsKey(sale.Town))
                {
                    salesByCity[sale.Town] = 0;
                }
                salesByCity[sale.Town] += sale.Price * sale.Quantity;
            }
            var salesList = salesByCity.Select(s => new SalesByCity() { Town = s.Key, Sales = s.Value }).ToList();
            return salesList;
        }
    }
}

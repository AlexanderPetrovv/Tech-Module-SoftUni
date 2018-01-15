using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Products
{
    class Product
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    class Products
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            List<Product> activeProducts = new List<Product>();

            if (File.Exists("productsDB.txt"))
            {
                string[] productsDB = File.ReadAllLines("productsDB.txt");

                foreach (var productInfo in productsDB)
                {
                    string[] productInfoTokens = productInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product
                    {
                        Name = productInfoTokens[0],
                        Type = productInfoTokens[1],
                        Price = decimal.Parse(productInfoTokens[2]),
                        Quantity = int.Parse(productInfoTokens[3])
                    };

                    activeProducts.Add(product);
                }
            }

            foreach (string line in lines)
            {
                string[] lineTokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (lineTokens[0] == "exit")
                {
                    break;
                }

                if (lineTokens.Length > 1)
                {
                    string productName = lineTokens[0];
                    string productType = lineTokens[1];
                    decimal productPrice = decimal.Parse(lineTokens[2]);
                    int productQuantity = int.Parse(lineTokens[3]);

                    Product currentProduct = new Product
                    {
                        Type = productType,
                        Name = productName,
                        Price = productPrice,
                        Quantity = productQuantity
                    };

                    if (activeProducts.Any(p => p.Name == productName && p.Type == productType))
                    {
                        activeProducts.First(p => p.Name == productName && p.Type == productType).Price = productPrice;
                        activeProducts.First(p => p.Name == productName && p.Type == productType).Quantity = productQuantity;
                        continue;
                    }
                    else
                    {
                        activeProducts.Add(currentProduct);
                        continue;
                    }
                }
                else
                {
                    string command = lineTokens[0];
                    switch (command)
                    {
                        case "stock":
                            StockProducts(activeProducts);
                            break;
                        case "analyze":
                            AnalyzeProducts();
                            break;
                        case "sales":
                            SaleProducts(activeProducts);
                            break;
                    }
                }
            }
        }

        static void SaleProducts(List<Product> activeProducts)
        {
            var typesIncomes = new Dictionary<string, List<decimal>>();
            foreach (Product product in activeProducts)
            {
                decimal income = product.Price * product.Quantity;
                if (!typesIncomes.ContainsKey(product.Type))
                {
                    typesIncomes[product.Type] = new List<decimal>();
                }
                typesIncomes[product.Type].Add(income);
            }

            PrintIncomesByProductType(typesIncomes);
        }

        static void PrintIncomesByProductType(Dictionary<string, List<decimal>> typesIncomes)
        {
            foreach (var typeIncome in typesIncomes.OrderByDescending(t => t.Value.Sum()))
            {
                string type = typeIncome.Key;
                if (typesIncomes[type] != null)
                {
                    decimal income = typeIncome.Value.Sum();
                    Console.WriteLine($"{type}: ${income:F2}");
                }
            }
        }

        static void AnalyzeProducts()
        {
            if (File.Exists("productsDB.txt"))
            {
                string[] stockedProducts = File.ReadAllLines("productsDB.txt");

                List<Product> allStockedProducts = ListAllStockedProducts(stockedProducts);

                PrintAllStockedProducts(allStockedProducts);
            }
            else
            {
                Console.WriteLine("No products stocked");
            }
        }

        static void PrintAllStockedProducts(List<Product> allStockedProducts)
        {
            if (allStockedProducts.Count() == 0)
            {
                Console.WriteLine("No products stocked");
            }
            else
            {
                foreach (var stockedProduct in allStockedProducts.OrderBy(p => p.Type))
                {
                    Console.WriteLine($"{stockedProduct.Type}, Product: {stockedProduct.Name}");
                    Console.WriteLine($"Price: ${stockedProduct.Price}, Amount Left: {stockedProduct.Quantity}");
                }
            }
        }

        static List<Product> ListAllStockedProducts(string[] stockedProducts)
        {
            List<Product> allStockedProducts = new List<Product>();
            foreach (var product in stockedProducts)
            {
                string[] productTokens = product.Split(' ');
                string name = productTokens[0];
                string type = productTokens[1];
                decimal price = decimal.Parse(productTokens[2]);
                int quantity = int.Parse(productTokens[3]);

                Product stockedProduct = new Product
                {
                    Name = name,
                    Type = type,
                    Price = price,
                    Quantity = quantity
                };

                allStockedProducts.Add(stockedProduct);
            }

            return allStockedProducts;
        }

        static void StockProducts(List<Product> activeProducts)
        {
            File.WriteAllText("productsDB.txt", String.Empty);
            foreach (Product product in activeProducts)
            {
                File.AppendAllLines("productsDB.txt",
                    new[] { $"{product.Name} {product.Type} {product.Price} {product.Quantity}" });
            }
        }
    }
}
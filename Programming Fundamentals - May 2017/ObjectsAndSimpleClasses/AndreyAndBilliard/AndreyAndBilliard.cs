using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int entitiesCnt = int.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < entitiesCnt; i++)
            {
                string[] inputLine = Console.ReadLine().Split('-');
                string product = inputLine[0];
                decimal price = decimal.Parse(inputLine[1]);

                shop[product] = price;
            }

            string line = Console.ReadLine();
            List<Customer> customers = new List<Customer>();

            while (line != "end of clients")
            {
                string[] tokens = line.Split(new [] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string customerName = tokens[0];
                string productToBuy = tokens[1];
                int quantity = int.Parse(tokens[2]);                

                if (shop.ContainsKey(productToBuy))
                {
                    if (customers.Any(c => c.Name == customerName))
                    {
                        Customer customer = customers.First(c => c.Name == customerName);
                        if (!customer.ShopList.ContainsKey(productToBuy))
                        {
                            customer.ShopList.Add(productToBuy, quantity);
                        }
                        else
                        {
                            customer.ShopList[productToBuy] += quantity;
                        }
                        customer.Bill += quantity * shop[productToBuy];
                    }
                    else
                    {
                        Customer customer = new Customer();
                        customer.Name = customerName;
                        customer.ShopList = new Dictionary<string, int>();
                        customer.ShopList.Add(productToBuy, quantity);
                        customer.Bill += quantity * shop[productToBuy];

                        customers.Add(customer);
                    }                                      
                }

                line = Console.ReadLine();
            }

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);                   
                }
                Console.WriteLine("Bill: {0:F2}", customer.Bill);
            }
            Console.WriteLine("Total bill: {0:F2}", customers.Sum(c => c.Bill));
        }
    }
}

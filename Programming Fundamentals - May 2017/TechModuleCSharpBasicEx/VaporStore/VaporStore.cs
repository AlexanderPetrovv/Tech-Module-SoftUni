using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var initialMoney = money;
            var currentPrice = 0.0;
            var game = Console.ReadLine();

            while (game != "Game Time")
            {
                
                switch (game)
                {
                    case "OutFall 4": currentPrice = 39.99; break;
                    case "CS: OG": currentPrice = 15.99; break;
                    case "Zplinter Zell": currentPrice = 19.99; break;
                    case "Honored 2": currentPrice = 59.99; break;
                    case "RoverWatch": currentPrice = 29.99; break;
                    case "RoverWatch Origins Edition": currentPrice = 39.99; break;
                    default: Console.WriteLine("Not Found"); game = Console.ReadLine(); continue;
                }

                if (money < currentPrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    money -= currentPrice;
                    Console.WriteLine($"Bought {game}");
                }

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                game = Console.ReadLine();
            }

            var totalSpent = initialMoney - money;
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
        }
    }
}

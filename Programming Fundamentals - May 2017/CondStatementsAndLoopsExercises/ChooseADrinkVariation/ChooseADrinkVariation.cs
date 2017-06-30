using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrinkVariation
{
    class ChooseADrinkVariation
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var drink = "";
            var price = 0.0;

            switch (profession.ToLower())
            {
                case "athlete":
                    drink = "Water";
                    price = 0.7;
                    break;
                case "businessman":
                case "businesswoman":
                    drink = "Coffee";
                    price = 1.0;
                    break;
                case "softuni student":
                    drink = "Beer";
                    price = 1.7;
                    break;
                default:
                    drink = "Tea";
                    price = 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {quantity * price:f2}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (true)
            {
                var ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    count++;
                }
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}

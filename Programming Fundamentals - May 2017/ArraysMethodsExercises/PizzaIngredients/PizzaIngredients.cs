using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            int strLength = int.Parse(Console.ReadLine());

            int cnt = 0;
            string addedIngr = String.Empty;
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == strLength)
                {
                    cnt++;                 
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    addedIngr += ingredients[i] + " ";
                    if (cnt == 10)
                    {
                        break;
                    }
                }
            }
            string[] finalIngr = addedIngr.Trim().Split(' ').ToArray();

            Console.WriteLine($"Made pizza with total of {cnt} ingredients.");
            Console.WriteLine("The ingredients are: {0}.", string.Join(", ", finalIngr));
        }
    }
}

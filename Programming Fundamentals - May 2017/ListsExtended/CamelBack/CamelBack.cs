using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelBack
{
    class CamelBack
    {
        static void Main(string[] args)
        {
            List<int> numBuildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());

            int len = numBuildings.Count();
            int rounds = 0;

            while (numBuildings.Count > camelBackSize)
            {
                RemoveFirstAndLastElements(numBuildings);
                rounds++;
            }
          
            PrintRoundsAndRemainingBuildings(rounds, numBuildings);
        }

        static void PrintRoundsAndRemainingBuildings(int rounds, List<int> numBuildings)
        {
            if (rounds == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", numBuildings));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numBuildings));
            }
        }

        static void RemoveFirstAndLastElements(List<int> numBuildings)
        {
            numBuildings.RemoveAt(0);
            numBuildings.RemoveAt(numBuildings.Count - 1);
        }
    }
}

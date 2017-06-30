using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
            foreach (int num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squareNums.Add(num);
                }
            }

            squareNums.Sort();
            squareNums.Reverse();

            //squareNums.Sort((a, b) => b.CompareTo(a));     // Sort in Reverse order with Lambda function
            //squareNums.Sort((a, b) => -1 * a.CompareTo(b));     // Sort in Reverse order with Lambda function
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}

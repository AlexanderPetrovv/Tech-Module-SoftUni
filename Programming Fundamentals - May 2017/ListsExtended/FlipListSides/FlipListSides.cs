using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 1; i < numbers.Count / 2; i++)
            {
                SwapElements(numbers, i, numbers.Count - 1 - i);
            }

            //List<string> numbers = Console.ReadLine().Split().ToList();
            //string firstElement = numbers[0];
            //string lastElement = numbers[numbers.Count - 1];
            //numbers.Reverse();
            //numbers[0] = firstElement;
            //numbers[numbers.Count - 1] = lastElement;

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SwapElements(List<int> numbers, int i, int last)
        {
            int temp = numbers[i];
            numbers[i] = numbers[last];
            numbers[last] = temp;
        }
    }
}

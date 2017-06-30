using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sumArray = new int[numbers.Length];

            for (int rot = 0; rot < rotations % numbers.Length; rot++)
            {
                RotateArray(numbers);

                for (int i = 0; i < numbers.Length; i++)
                {                   
                    sumArray[i] += numbers[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }

        private static void RotateArray(int[] numbers)
        {
            int lastElement = numbers[numbers.Length - 1];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = lastElement;
        }
    }
}

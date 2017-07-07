using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            InsertionSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void InsertionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        Swap(numbers, j, j - 1);
                    }

                    j--;
                }
            }
        }

        static void Swap(int[] numbers, int currentIndex, int previousIndex)
        {
            int temp = numbers[currentIndex];
            numbers[currentIndex] = numbers[previousIndex];
            numbers[previousIndex] = temp;
        }
    }
}

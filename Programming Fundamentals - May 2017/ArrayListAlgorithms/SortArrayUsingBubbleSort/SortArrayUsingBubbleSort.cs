using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentIndex = i;
                    int nextIndex = i + 1;
                    if (numbers[currentIndex] > numbers[nextIndex])
                    {
                        Swap(numbers, currentIndex, nextIndex);
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void Swap(int[] numbers, int currentIndex, int nextIndex)
        {
            int temp = numbers[currentIndex];
            numbers[currentIndex] = numbers[nextIndex];
            numbers[nextIndex] = temp;
        }
    }
}

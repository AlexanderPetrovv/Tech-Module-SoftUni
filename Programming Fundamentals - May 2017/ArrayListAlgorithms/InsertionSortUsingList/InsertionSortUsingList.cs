using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sortedNumbers = InsertionSort(numbers);
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }

        static List<int> InsertionSort(List<int> numbers)
        {
            List<int> sortedNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isInserted = false;
                int currentNum = numbers[i];
                for (int j = 0; j < sortedNumbers.Count; j++)
                {
                    int sortedListElement = sortedNumbers[j];
                    if (currentNum <= sortedListElement)
                    {
                        isInserted = true;
                        sortedNumbers.Insert(Math.Max(0, j), currentNum);
                        break;
                    }
                }

                if (!isInserted)
                {
                    sortedNumbers.Add(currentNum);
                }
            }
            return sortedNumbers;
        }
    }
}

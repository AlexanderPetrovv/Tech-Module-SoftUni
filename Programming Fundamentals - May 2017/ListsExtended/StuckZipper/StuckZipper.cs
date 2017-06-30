using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int firstListLeastDigits = CalcLeastDigitsOfNums(firstList);
            int secondListLeastDigits = CalcLeastDigitsOfNums(secondList);

            int leastDigits = Math.Min(firstListLeastDigits, secondListLeastDigits); 

            RemoveElementsWithMoreDigits(firstList, leastDigits);
            RemoveElementsWithMoreDigits(secondList, leastDigits);

            var zippedList = ZipListsTogether(firstList, secondList);

            Console.WriteLine(string.Join(" ", zippedList));
        }

        static int CalcLeastDigitsOfNums(List<int> firstList)
        {
            int leastDigits = int.MaxValue;
            for (int i = 0; i < firstList.Count; i++)
            {
                int currentNumDigits = GetNumberOfDigits(firstList[i]);
                if (currentNumDigits < leastDigits)
                {
                    leastDigits = currentNumDigits;
                }
            }
            return leastDigits;
        }

        static List<int> ZipListsTogether(List<int> firstList, List<int> secondList)
        {
            List<int> zippedList = new List<int>();
            int len = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < len; i++)
            {
                if (i < secondList.Count)
                {
                    zippedList.Add(secondList[i]);
                }

                if (i < firstList.Count)
                {
                    zippedList.Add(firstList[i]);
                }
            }
            return zippedList;
        }

        static void RemoveElementsWithMoreDigits(List<int> numsList, int leastDigits)
        {
            for (int i = 0; i < numsList.Count; i++)
            {
                int currentNum = numsList[i];
                int currentNumDigits = GetNumberOfDigits(currentNum);
                if (leastDigits < currentNumDigits)
                {
                    numsList.Remove(numsList[i]);
                    i--;
                }
            }
        }

        static int GetNumberOfDigits(int number)
        {
            int digitsCnt = 0;
            int num = Math.Abs(number);
            while (num > 0)
            {
                num /= 10;
                digitsCnt++;
            }
            return digitsCnt;
        }
    }
}

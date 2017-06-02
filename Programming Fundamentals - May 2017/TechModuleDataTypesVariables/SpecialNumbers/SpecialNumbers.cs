using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            // A number is special when the sum of its digits is 5, 7 or 11

            int numCnt = int.Parse(Console.ReadLine());

            for (int num = 1; num <= numCnt; num++)
            {
                int digitSum = 0;
                int currentNum = num;
                while (currentNum > 0)
                {
                    digitSum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool isSpecial = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}

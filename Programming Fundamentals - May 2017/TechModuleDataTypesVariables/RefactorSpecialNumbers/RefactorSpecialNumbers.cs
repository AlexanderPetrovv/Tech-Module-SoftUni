using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());    // kolko becomes n
            // all variables are now declared inside loop for shorter scope/lifetime
            for (int num = 1; num <= n; num++)   // ch becomes num
            {
                int currentNum = num;           // takova becomes currentNum
                int digitSum = 0;               // obshto becomes digitSum and is declared inside for loop
                while (currentNum > 0)          // (currentNum > 0) not (num > 0)
                {
                    digitSum += currentNum % 10;       // currentNum substitutes num
                    currentNum = currentNum / 10;
                }
                bool isSpecial = false;
                isSpecial = (digitSum == 5) || (digitSum == 7) || (digitSum == 11);     // toe becomes boolean variable isSpecial
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}

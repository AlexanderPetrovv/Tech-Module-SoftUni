using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Create a method GetMax(int a, int b), that returns the largest of two numbers.
Write a program that reads three numbers from the console and prints the biggest of them.
Use the GetMax(…) method you just created.
*/

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = GetMax(GetMax(num1, num2), num3);
            Console.WriteLine(maxNum);
        }

        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
    }
}

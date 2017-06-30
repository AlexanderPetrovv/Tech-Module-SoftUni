using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int numsCnt = int.Parse(Console.ReadLine());
            int[] numbers = new int[numsCnt];

            for (int i = 0; i < numsCnt; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}\r\nMin = {1}\r\nMax = {2}\r\nAverage = {3}\r\n",
                numbers.Sum(),
                numbers.Min(),
                numbers.Max(),
                numbers.Average());
        }
    }
}

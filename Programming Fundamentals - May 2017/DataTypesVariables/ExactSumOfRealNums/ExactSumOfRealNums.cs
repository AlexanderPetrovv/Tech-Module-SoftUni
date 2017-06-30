using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNums
{
    class ExactSumOfRealNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal exactSum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal numberToAdd = decimal.Parse(Console.ReadLine());
                exactSum += numberToAdd;
            }
            Console.WriteLine(exactSum);
        }
    }
}

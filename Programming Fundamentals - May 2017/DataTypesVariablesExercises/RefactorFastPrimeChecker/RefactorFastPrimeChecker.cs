using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorFastPrimeChecker
{
    class RefactorFastPrimeChecker
    {
        static void Main(string[] args)
        {
            int limitNum = int.Parse(Console.ReadLine());        // ___Do___ becomes limitNum
            for (int num = 2; num <= limitNum; num++)  // DAVIDIM becomes num and num starts from 2
            {
                bool isPrime = true;                     // TowaLIE becomes isPrime
                for (int divider = 2; divider <= Math.Sqrt(num); divider++)    // delio becomes divider
                {
                    if (num % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");   // "is prime" is gone
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            bool[] primes = new bool[limit + 1];
            
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 0; i <= limit; i++)
            {
                if (!primes[i])
                {
                    continue;
                }

                Console.Write(i + " ");

                for (int p = 2 * i; p <= limit; p += i)
                {
                    primes[p] = false;
                }
            }
            Console.WriteLine();
        }
    }
}

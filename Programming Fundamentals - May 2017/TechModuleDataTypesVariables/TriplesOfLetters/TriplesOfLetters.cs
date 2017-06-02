using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num1 = 0; num1 <= n - 1; num1++)
            {
                for (int num2 = 0; num2 <= n - 1; num2++)
                {
                    for (int num3 = 0; num3 <= n - 1; num3++)
                    {
                        char letter1 = (char)('a' + num1);
                        char letter2 = (char)('a' + num2);
                        char letter3 = (char)('a' + num3);
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }

            //for (char letter1 = 'a'; letter1 < 'a' + n; letter1++)
            //{
            //    for (char letter2 = 'a'; letter2 < 'a' + n; letter2++)
            //    {
            //        for (char letter3 = 'a'; letter3 < 'a' + n; letter3++)
            //        {
            //            Console.WriteLine($"{letter1}{letter2}{letter3}");
            //        }
            //    }
            //}
        }
    }
}

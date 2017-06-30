using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));

            while (true)
            {
                if (number % 2 == 1)
                {
                    break;
                }
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("The number is: " + number);

            //while (number % 2 != 1)
            //{
            //    Console.WriteLine("Please write an odd number.");
            //    number = Math.Abs(int.Parse(Console.ReadLine()));
            //}

            //Console.WriteLine("The number is: " + number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker2
{
    class NumberChecker2
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                try
                {
                    number = Math.Abs(int.Parse(Console.ReadLine()));
                }
                catch (Exception)
                {
                    number = 0;
                    if (number == 0)
                    {
                        Console.WriteLine("Not a number!");
                    }
                }
                if (number % 2 == 1)
                    break;
                Console.WriteLine("Please write an odd number!");
            }

            Console.WriteLine("The odd number is: " + number);
        }
    }
}

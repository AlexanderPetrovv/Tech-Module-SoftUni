using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} X {i} = {number * i}");
            //}

            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}

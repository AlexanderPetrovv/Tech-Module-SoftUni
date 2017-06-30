using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
                number2++;
            } while (number2 <= 10);
        }
    }
}

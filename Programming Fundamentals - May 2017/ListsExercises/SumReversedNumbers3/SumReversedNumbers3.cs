using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers3
{
    class SumReversedNumbers3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.ReadLine()
                .Split()
                .Select(num => int.Parse(new string(num.Reverse().ToArray())))
                .Sum());
        }
    }
}

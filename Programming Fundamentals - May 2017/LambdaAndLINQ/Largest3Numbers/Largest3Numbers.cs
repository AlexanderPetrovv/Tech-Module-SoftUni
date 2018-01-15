using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList()));
        }
    }
}

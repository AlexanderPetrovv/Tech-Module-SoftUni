using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertFromBaseTenToBaseN
{
    class ConvertFromBaseTenToBaseN
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] tokens = inputLine.Split(' ');
            var @base = int.Parse(tokens[0]);
            var number = BigInteger.Parse(tokens[1]);

            StringBuilder result = new StringBuilder();

            while (number > 0)
            {
                var digit = number % @base;
                result.Append(digit);
                number /= @base;
            }

            Console.WriteLine(new string(result.ToString().Reverse().ToArray()));
        }
    }
}

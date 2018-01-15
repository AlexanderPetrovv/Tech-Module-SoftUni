using System;
using System.Numerics;

namespace ConvertFromBaseNToBaseTen
{
    class ConvertFromBaseNToBaseTen
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] tokens = inputLine.Split(' ');
            int @base = int.Parse(tokens[0]);
            var number = BigInteger.Parse(tokens[1]);

            var numberDigits = tokens[1].Length;

            BigInteger result = 0;
            for (int i = 0; i < numberDigits; i++)
            {
                int lastDigit = (int)(number % 10);
                result += (lastDigit * BigInteger.Pow(@base, i));
                number /= 10;
            }

            Console.WriteLine(result.ToString());
        }
    }
}

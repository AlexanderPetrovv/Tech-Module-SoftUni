using System;

namespace Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int amountOfPhoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPhoenixes; i++)
            {
                int bodyLength = int.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                var totalYears = ((decimal)Math.Pow(bodyLength, 2) * (bodyWidth + 2 * wingLength));
                Console.WriteLine(totalYears);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are a house builder and you need to buy the materials for one of your clients.
This is quite a special house and it needs special materials.
The house needs 4 sbyte variables and 10 int variables.
You will receive two numbers from the console, which will be the prices of the materials.
One will be an integer and the other will be sbyte, but you do not know the order in which they will be given.
The int number will be the price of the int materials and the sbyte number will be the price of the sbyte materials.
Calculate the total price of the materials and print them on the console.
*/

namespace HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sbytePrice = 0;
            long intPrice = 0;

            if (num1 <= sbyte.MaxValue)
            {
                sbytePrice = 4 * num1;
                intPrice = (long)10 * num2;
            }

            if (num2 <= sbyte.MaxValue)
            {
                sbytePrice = 4 * num2;
                intPrice = (long)10 * num1;
            }

            long totalPrice = sbytePrice + intPrice;
            Console.WriteLine(totalPrice);
        }

        // Console.WriteLine(Math.Max(num1, num2) * 10 + Math.Min(num1, num2) * 4);
    }
}

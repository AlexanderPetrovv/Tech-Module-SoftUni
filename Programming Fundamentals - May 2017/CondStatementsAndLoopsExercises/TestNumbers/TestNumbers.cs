using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var stopSum = int.Parse(Console.ReadLine());

            var cnt = 0;
            var sum = 0;

            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    if (sum < stopSum)
                    {
                        sum += i * j * 3;
                        cnt++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sum >= stopSum)
                {
                    break;
                }
            }

            if (sum >= stopSum)
            {
                Console.WriteLine($"{cnt} combinations");
                Console.WriteLine($"Sum: {sum} >= {stopSum}");
            }
            else
            {
                Console.WriteLine($"{cnt} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}

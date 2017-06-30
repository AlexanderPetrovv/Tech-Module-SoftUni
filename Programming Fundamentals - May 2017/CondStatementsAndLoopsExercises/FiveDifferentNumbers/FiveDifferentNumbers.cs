using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var diff = Math.Abs(a - b);

            if (diff < 5)
            {
                Console.WriteLine("No");
            }

            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = n1; n2 < b; n2++)
                {
                    for (int n3 = n2; n3 < b; n3++)
                    {
                        for (int n4 = n3; n4 < b; n4++)
                        {
                            for (int n5 = n4; n5 <= b; n5++)
                            {
                                if (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

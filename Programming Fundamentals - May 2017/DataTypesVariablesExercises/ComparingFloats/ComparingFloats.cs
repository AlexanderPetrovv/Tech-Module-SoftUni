using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            // Equal or not with precision eps = 0.000001
            float epsilon = 0.000001f;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double diff = Math.Abs(num1 - num2);
            bool areEqual = false;
            if (diff > epsilon)
            {
                Console.WriteLine(areEqual);
            }
            else
            {
                areEqual = true;
                Console.WriteLine(areEqual);
            }
        }
    }
}

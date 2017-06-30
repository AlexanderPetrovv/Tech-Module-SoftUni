using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int decimalNum = int.Parse(Console.ReadLine());

            string hexadecNum = Convert.ToString(decimalNum, 16).ToUpper();
            Console.WriteLine(hexadecNum);
            string binaryNum = Convert.ToString(decimalNum, 2);
            Console.WriteLine(binaryNum);
        }
    }
}

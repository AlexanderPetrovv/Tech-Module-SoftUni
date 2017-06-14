using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings3
{
    class ReverseAnArrayOfStrings3
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < str.Length / 2; i++)
            {
                ReverseStringElements(str, i, str.Length - i - 1);
            }
            Console.WriteLine(string.Join(" ", str));
        }

        static void ReverseStringElements(string[] str, int i, int j)
        {
            var oldElement = str[i];
            str[i] = str[j];
            str[j] = oldElement;
        }
    }
}

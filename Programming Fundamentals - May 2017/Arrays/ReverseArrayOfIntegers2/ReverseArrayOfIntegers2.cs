using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers2
{
    class ReverseArrayOfIntegers2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int length = array.Length;
            int[] reversed = new int[length];
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
            Console.WriteLine();
        }
    }
}

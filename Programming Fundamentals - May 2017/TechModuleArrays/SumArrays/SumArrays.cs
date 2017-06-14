using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program that reads two arrays of integers and sums them.
When the arrays are not of the same size, duplicate the smaller array a few times. 
*/

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longerArr = Math.Max(array1.Length, array2.Length);
            int[] sumArray = new int[longerArr];

            for (int i = 0; i < longerArr; i++)
            {
                sumArray[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}

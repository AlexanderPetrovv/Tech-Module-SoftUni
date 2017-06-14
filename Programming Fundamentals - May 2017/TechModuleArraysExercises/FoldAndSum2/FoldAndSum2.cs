using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum2
{
    class FoldAndSum2
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int idx = arr.Length / 4;

            int counter = 0;
            while (idx < arr.Length * 3 / 4)
            {

                if (idx < arr.Length / 2)
                {
                    Console.Write(arr[idx] + arr[arr.Length / 4 - ++counter] + " ");
                }
                else
                {
                    if (idx == arr.Length / 2) counter = 0;
                    Console.Write(arr[idx] + arr[arr.Length - ++counter] + " ");
                }

                idx++;
            }
            Console.WriteLine();
        }
    }
}

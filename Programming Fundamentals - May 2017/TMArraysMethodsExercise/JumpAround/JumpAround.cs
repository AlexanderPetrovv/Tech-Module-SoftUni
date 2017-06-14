using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long sum = 0;
            int index = 0;
            int step = arr[0];
            while (true)
            {
                sum += step;
                if (index + step > arr.Length - 1)
                {
                    if (index - step < 0)
                    {
                        break;
                    }
                    else
                    {
                        index -= step;      
                    }
                }
                else
                {
                    index += step;
                }
                step = arr[index];
            }

            Console.WriteLine(sum);
        }
    }
}

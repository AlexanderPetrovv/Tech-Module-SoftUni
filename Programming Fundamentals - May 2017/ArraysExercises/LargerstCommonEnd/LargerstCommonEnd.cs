using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerstCommonEnd
{
    class LargerstCommonEnd
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Split(' ').ToArray();

            int length = Math.Min(array1.Length, array2.Length);
            int commonLeftElementsCnt = 0;
            int commonRightElementsCnt = 0;
            for (int i = 0; i < length; i++)
            {
                if (array1[i] == array2[i])
                {
                    commonLeftElementsCnt++;
                }

                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                {
                    commonRightElementsCnt++;
                }
            }

            if (commonLeftElementsCnt >= commonRightElementsCnt)
            {
                Console.WriteLine(commonLeftElementsCnt);
            }
            else
            {
                Console.WriteLine(commonRightElementsCnt);
            }
        }
    }
}

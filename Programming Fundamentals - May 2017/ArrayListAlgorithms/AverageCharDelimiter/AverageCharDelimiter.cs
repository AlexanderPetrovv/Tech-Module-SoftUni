using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharDelimiter
{
    class AverageCharDelimiter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            int charSum = 0;
            int charCnt = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    charSum += input[i][j];
                    charCnt++;
                }
            }

            char averageSumChar = (char)(charSum / charCnt);
            string delimiter = averageSumChar.ToString().ToUpper();

            Console.WriteLine(string.Join(delimiter, input));
        }
    }
}

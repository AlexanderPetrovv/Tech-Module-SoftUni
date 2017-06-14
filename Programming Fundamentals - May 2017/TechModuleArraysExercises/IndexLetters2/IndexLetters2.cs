using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLetters2
{
    class IndexLetters2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] charArr = word.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine($"{charArr[i]} -> {(int)(charArr[i] - 97)}");
            }
        }
    }
}

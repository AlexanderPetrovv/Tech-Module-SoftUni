using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLetters3
{
    class IndexLetters3
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            foreach (var letter in word)
            {
                Console.WriteLine($"{letter} -> {letter - 'a'}");
            }
        }
    }
}

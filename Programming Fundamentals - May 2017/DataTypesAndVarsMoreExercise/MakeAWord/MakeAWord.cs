using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program, which combines n characters and prints on a single line the combinations of these characters.
*/

namespace MakeAWord
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());

            string word = String.Empty;
            for (int i = 0; i < numberOfChars; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += "" + symbol;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}

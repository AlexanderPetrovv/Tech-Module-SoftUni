using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program, which reads three lines from the console.
On the first line, there will be delimiter (char) – you have to separate the strings by this delimiter.
The second line will be either “even” or “odd”. If you receive “odd”, you have to take every odd string and vice versa if you receive “even”.
The last line will be the number of lines – n which you will receive.
The first iteration of the loop starts from 1. Print the newly created string on a new line.
*/

namespace StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());

            string newString = String.Empty;
            for (int currentLine = 1; currentLine <= numberOfLines; currentLine++)
            {
                string @string = Console.ReadLine();

                if (oddOrEven == "odd" && currentLine % 2 == 1)
                {
                    newString += @string + delimiter;
                }
                else if (oddOrEven == "even" && currentLine % 2 == 0)
                {
                    newString += @string + delimiter;
                }
            }
            Console.WriteLine(newString.Remove(newString.Length - 1));
        }
    }
}

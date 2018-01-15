using System;
using System.Linq;

namespace Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string border = GetBorder(line);
                
                if (border == String.Empty)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (border.Length * 2 < line.Length)
                {
                    string core = line.Substring(border.Length, line.Length - 2 * border.Length);
                    Console.WriteLine($"{core}{border}{core}");
                }                

                line = Console.ReadLine();
            }
        }

        static string GetBorder(string line)
        {
            string leftHalf = line.Substring(0, line.Length / 2);
            string reversedLine = new string(line.Reverse().ToArray());
            string rightHalf = new string(reversedLine.Substring(0, line.Length / 2).Reverse().ToArray());

            while (!String.Equals(leftHalf, rightHalf))
            {
                leftHalf = leftHalf.Remove(leftHalf.Length - 1, 1);
                rightHalf = rightHalf.Remove(0, 1);
            }
            return leftHalf;
        }
    }
}

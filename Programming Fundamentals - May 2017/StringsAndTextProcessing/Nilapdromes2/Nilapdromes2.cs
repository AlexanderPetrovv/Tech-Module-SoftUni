using System;

namespace Nilapdromes2
{
    class Nilapdromes2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string nilapdrome = ReturnNilapdrome(line);

                if (nilapdrome != String.Empty)
                {
                    Console.WriteLine(nilapdrome);
                }

                line = Console.ReadLine();
            }
        }

        static string ReturnNilapdrome(string line)
        {
            int middleIndex = line.Length / 2;

            string border = "";
            int leftIndex = 0;

            for (int i = middleIndex + 1; i < line.Length; i++)
            {
                if (line[leftIndex] == line[i])
                {
                    border += line[i];
                    leftIndex++;
                }
                else
                {
                    border = "";
                    leftIndex = 0;
                    if (line[i] == line[leftIndex])     // CHECKS IF BORDER IS THE LAST SYMBOL && IS ONE SYMBOL LONG 
                    {
                        border += line[i];
                        leftIndex++;
                    }
                }
            }

            if (border != String.Empty)
            {
                int leftIndexMiddle = line.IndexOf(border);
                int rightIndexMiddle = line.LastIndexOf(border);

                string core = line
                    .Substring(leftIndexMiddle + border.Length,
                               rightIndexMiddle - leftIndexMiddle - border.Length);
                if (core != String.Empty)
                {
                    return core + border + core;
                }
            }

            return String.Empty;
        }
    }
}

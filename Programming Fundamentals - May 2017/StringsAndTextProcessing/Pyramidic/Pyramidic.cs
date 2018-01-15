using System;
using System.Collections.Generic;
using System.Linq;

namespace Pyramidic
{
    class Pyramidic
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> inputLines = new List<string>();

            for (int i = 0; i < n; i++)
            {
                inputLines.Add(Console.ReadLine());
            }

            List<string> pyramids = new List<string>();

            for (int i = 0; i < inputLines.Count; i++)
            {
                var currentLine = inputLines[i];

                for (int ch = 0; ch < currentLine.Length; ch++)
                {
                    char symbol = currentLine[ch];
                    string pyramid = FindPyramid(symbol, inputLines, i);
                    pyramids.Add(pyramid);
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(p => p.Length).First());
        }

        static string FindPyramid(char symbol, List<string> inputLines, int lineNum)
        {
            int count = 3;
            string pyramid = "" + symbol;
            for (int i = lineNum + 1; i < inputLines.Count; i++)
            {
                string step = new string(symbol, count);

                if (inputLines[i].Contains(step))
                {
                    pyramid += Environment.NewLine + step; 
                    count += 2;
                }
                else
                {
                    return pyramid;
                }
            }
            return pyramid;
        }
    }
}

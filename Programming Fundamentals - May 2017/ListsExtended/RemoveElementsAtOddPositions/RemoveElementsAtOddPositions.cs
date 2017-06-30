using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> filteredStr = new List<string>();
            RemoveOddPosElements(input, filteredStr);
            Console.WriteLine(string.Join("", filteredStr));
        }

        static void RemoveOddPosElements(List<string> input, List<string> filteredStr)
        {            
            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 == 1)
                {
                    filteredStr.Add(input[i]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Spyfer
{
    class Spyfer
    {
        static void Main(string[] args)
        {
            List<int> coordinates = Console.ReadLine().Split().Select(int.Parse).ToList();

            int i = 0;
            while (i < coordinates.Count)
            {
                int currentNum = coordinates[i];

                if (coordinates.Count > 1 && i == 0)   // The case where there is no previous number
                {
                    int nextNum = coordinates[i + 1];
                    if (currentNum == nextNum)
                    {
                        coordinates.RemoveAt(i + 1);
                        i = -1;
                    }
                }
                else if (coordinates.Count > 1 && i == coordinates.Count - 1)  // The case where there is no next number
                {
                    int previousNum = coordinates[i - 1];
                    if (currentNum == previousNum)
                    {
                        coordinates.RemoveAt(i - 1);
                        i = -1;
                    }
                }
                else
                {
                    if (coordinates.Count > 2 && coordinates[i] == (coordinates[i + 1] + coordinates[i - 1]))
                    {
                        coordinates.RemoveAt(i + 1);
                        coordinates.RemoveAt(i - 1);
                        i = -1;
                    }
                }
                i++;
            }

            Console.WriteLine(string.Join(" ", coordinates));
        }
    }
}

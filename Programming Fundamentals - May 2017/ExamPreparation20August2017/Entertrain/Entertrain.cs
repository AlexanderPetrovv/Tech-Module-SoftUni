using System;
using System.Collections.Generic;
using System.Linq;

namespace Entertrain
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());

            List<int> wagonsWeights = new List<int>();

            string input;

            while ((input = Console.ReadLine()) != "All ofboard!")
            {
                wagonsWeights.Add(int.Parse(input));
                long sumWeight = wagonsWeights.Sum();

                if (sumWeight > power)
                {
                    int average = (int)wagonsWeights.Average();
                    int closestNum = GetClosestToAverage(wagonsWeights, average);
                    wagonsWeights.RemoveAt(wagonsWeights.IndexOf(closestNum));
                }
            }

            PrintResult(wagonsWeights, power);
        }

        static int GetClosestToAverage(List<int> wagonsWeights, int average)
        {
            int closest = int.MaxValue;
            int minDiff = int.MaxValue;

            foreach (int wagonWeight in wagonsWeights)
            {
                int difference = Math.Abs(wagonWeight - average);
                if (minDiff > difference)
                {
                    minDiff = difference;
                    closest = wagonWeight;
                }
            }
            return closest;
        }

        static void PrintResult(List<int> wagonsWeights, int power)
        {
            wagonsWeights.Reverse();
            Console.WriteLine(string.Join(" ", wagonsWeights) + " " + power);
        }
    }
}

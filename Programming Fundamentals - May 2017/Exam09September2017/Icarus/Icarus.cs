using System;
using System.Linq;

namespace Icarus
{
    class Icarus
    {
        static int[] planeNumbers;

        static int startIndex;

        static int initialDamage;

        static void Main(string[] args)
        {
            planeNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            startIndex = int.Parse(Console.ReadLine());
            initialDamage = 1;

            string command;

            while ((command = Console.ReadLine()) != "Supernova")
            {
                string[] tokens = command.Split();
                string direction = tokens[0];
                int steps = int.Parse(tokens[1]);

                if (direction == "left")
                {
                    StepLeft(steps);                   
                }
                else if (direction == "right")
                {
                    StepRight(steps);                    
                }
            }

            Console.WriteLine(string.Join(" ", planeNumbers));
        }

        static void StepRight(int steps)
        {
            while (steps > 0)
            {
                startIndex++;
                if (startIndex > planeNumbers.Length - 1)
                {
                    startIndex = 0;
                    initialDamage++;
                }

                planeNumbers[startIndex] -= initialDamage;
                steps--;
            }
        }

        static void StepLeft(int steps)
        {
            while (steps > 0)
            {
                startIndex--;
                if (startIndex < 0)
                {
                    startIndex = planeNumbers.Length - 1;
                    initialDamage++;
                }

                planeNumbers[startIndex] -= initialDamage;
                steps--;
            }
        }
    }
}

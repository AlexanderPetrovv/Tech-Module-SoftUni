using System;
using System.Collections.Generic;
using System.Linq;

namespace BoomingCannon
{
    class BoomingCannon
    {
        static void Main(string[] args)
        {
            int[] inputParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotDistance = inputParams[0];
            int elementsToDestroy = inputParams[1];

            string input = Console.ReadLine();

            List<string> destroyedTargets = new List<string>();

            int cannonIndex = input.IndexOf("\\<<<");
            int cannonSize = 4;

            while (cannonIndex != -1)
            {
                int destroyedRange = cannonIndex + cannonSize + shotDistance + elementsToDestroy;
                int nextTargetIndex = input.IndexOf("\\<<<", cannonIndex + 1);

                if (nextTargetIndex != -1 && nextTargetIndex < destroyedRange)
                {
                    destroyedRange = nextTargetIndex;
                }

                int impactIndex = cannonIndex + cannonSize + shotDistance;
                int targetLength = destroyedRange - impactIndex;

                if (targetLength > 0)
                {
                    if (impactIndex + targetLength >= input.Length)
                    {
                        targetLength = input.Length - impactIndex;
                    }

                    string destroyedTarget = input.Substring(impactIndex, targetLength);
                    destroyedTargets.Add(destroyedTarget);
                }
                cannonIndex = input.IndexOf("\\<<<", cannonIndex + 1);
            }
            Console.WriteLine(string.Join("/\\", destroyedTargets));
        }
    }
}

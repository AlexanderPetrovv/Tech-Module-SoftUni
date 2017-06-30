using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft
{
    class Winecraft
    {
        static void Main(string[] args)
        {
            // Missing something, not completed!
            List<int> grapes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int growthDays = int.Parse(Console.ReadLine());

            bool[] isGreatGrape = new bool[grapes.Count + 1];   // Longer than grapes cnt to avoid out of range exception later
            CheckForGreatGrapes(grapes, isGreatGrape);      // Check all grapes for great grapes

            while (grapes.Count >= growthDays)
            {
                for (int i = 0; i < growthDays; i++)
                {
                    IncrementGrapes(grapes, isGreatGrape);
                    CheckForGreatGrapes(grapes, isGreatGrape);   // Check again after incrementing for new found great grapes
                }

                CheckForWeakGrapes(grapes, growthDays);
            } 

            Console.WriteLine(string.Join(" ", grapes));
        }

        static void CheckForWeakGrapes(List<int> grapes, int growthDays)
        {
            int healthyGrapes = grapes.Count;
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= growthDays)
                {
                    healthyGrapes--;
                    grapes[i] = 0;
                }
            }

            if (healthyGrapes < growthDays)
            {
                LeaveHealthyGrapesOnly(healthyGrapes, growthDays, grapes);
            }
        }

        static void LeaveHealthyGrapesOnly(int healthyGrapes, int growthDays, List<int> grapes)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] < growthDays)
                {
                    grapes.Remove(grapes[i]);
                    i--;
                }
            }
        }

        static void IncrementGrapes(List<int> grapes, bool[] isGreatGrape)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (isGreatGrape[i])
                {
                    grapes[i]++;
                    if (grapes[i - 1] > 0)
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }

                    if (grapes[i + 1] > 0)
                    {
                        grapes[i]++;
                        grapes[i + 1]--;
                    }
                }
                else
                {
                    if (i == 0 && !isGreatGrape[i + 1])
                    {
                        grapes[i]++;
                    }
                    else if (i == grapes.Count - 1 && !isGreatGrape[i - 1])
                    {
                        grapes[i]++;
                    }
                    else if (!isGreatGrape[i + 1] && !isGreatGrape[i - 1])
                    {
                        grapes[i]++;
                    }
                }
            }
        }

        static void CheckForGreatGrapes(List<int> grapes, bool[] isGreatGrape)
        {
            for (int i = 1; i < grapes.Count - 1; i++)
            {
                int currentGrape = grapes[i];
                int previousGrape = grapes[i - 1];
                int nextGrape = grapes[i + 1];
                if (currentGrape > previousGrape && currentGrape > nextGrape)
                {
                    isGreatGrape[i] = true;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winecraft2
{
    class Winecraft2
    {
        static int[] grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine()
            .Split(new char[] { ' ' },
                   StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int growthDays = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < growthDays; i++)
                {
                    IncrementGrapes();
                }

                KillGrapesWeakerOrEqualTo(growthDays);
            } while (HealthyGrapesAreMoreOrEqualTo(growthDays));

            PrintRemainingGrapes();
        }

        static bool HealthyGrapesAreMoreOrEqualTo(int growthDays)
        {
            return grapes.Where(x => x > growthDays).Count() >= growthDays;
        }

        static void IncrementGrapes()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (!IsAlive(i))
                {
                    continue;
                }

                if (IsGreaterGrape(i))
                {
                    grapes[i]++;
                    if (IsAlive(i - 1))
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }

                    if (IsAlive(i + 1))
                    {
                        grapes[i]++;
                        grapes[i + 1]--;
                    }
                }
                else if (IsLesserGrape(i))
                {

                }
                else
                {
                    grapes[i]++;
                }
            }
        }

        static bool IsGreaterGrape(int i)
        {
            if (i <= 0 || i >= (grapes.Length - 1))
            {
                return false;
            }

            return (grapes[i] > grapes[i - 1] &&
                    grapes[i] > grapes[i + 1]);
        }

        static bool IsLesserGrape(int i)
        {
            return (IsGreaterGrape(i - 1) || IsGreaterGrape(i + 1));
        }

        static bool IsAlive(int i)
        {
            if (i < 0 || i >= grapes.Length)
            {
                return false;
            }

            return grapes[i] > 0;
        }

        static void KillGrapesWeakerOrEqualTo(int growthDays)
        {
            for (int j = 0; j < grapes.Length; j++)
            {
                if (grapes[j] <= growthDays)
                {
                    grapes[j] = 0;
                }
            }
        }

        static void PrintRemainingGrapes()
        {
            for (int i = 0; i < grapes.Length; i++)
            {
                if (IsAlive(i))
                {
                    Console.Write(grapes[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

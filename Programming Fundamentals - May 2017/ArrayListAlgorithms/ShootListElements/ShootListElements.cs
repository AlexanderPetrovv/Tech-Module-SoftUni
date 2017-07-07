using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            List<int> list = new List<int>();
            double average;
            int? lastShotElement = null;

            while (line != "stop")
            {
                while (line != "bang")
                {
                    list.Insert(0, int.Parse(line));
                    line = Console.ReadLine();
                }

                if (list.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastShotElement);
                    return;
                }

                average = GetAverage(list);

                if (list.Count == 1)
                {
                    RemoveTheOnlyElementLeft(list, ref lastShotElement);
                    line = Console.ReadLine();
                    continue;
                }
                RemoveFirstSmallerThanAverageElement(list, average, ref lastShotElement);
                DecrementEveryElement(list);
                
                line = Console.ReadLine();
            }

            if (list.Count == 0)
            {
                Console.WriteLine("you shot them all. last one was {0}", lastShotElement);
            }
            else
            {
                Console.WriteLine("survivors: " + string.Join(" ", list));
            }
        }

        static void RemoveTheOnlyElementLeft(List<int> list, ref int? lastShotElement)
        {
            for (int i = 0; i < list.Count; i++)
            {
                    lastShotElement = list[i];
                    Console.WriteLine("shot {0}", lastShotElement);
                    list.Remove(list[i]);
            }
        }

        static void DecrementEveryElement(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i]--;
            }
        }

        static void RemoveFirstSmallerThanAverageElement(List<int> list, double average, ref int? lastShotElement)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < average)
                {                    
                    lastShotElement = list[i];
                    Console.WriteLine("shot {0}", lastShotElement);
                    list.Remove(list[i]);
                    break;
                }
            }
        }

        static double GetAverage(List<int> list)
        {
            double average = 0d;
            double sum = 0d;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];                
            }
            average = sum / list.Count;
            return average;
        }
    }
}

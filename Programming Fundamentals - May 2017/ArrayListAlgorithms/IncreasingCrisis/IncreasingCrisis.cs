using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                List<int> current = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                if (i == 0)
                {
                    result.AddRange(current);
                    continue;
                }

                for (int j = 0; j < result.Count; j++)
                {
                    if (current[0] >= result[j])
                    {
                        index = j + 1;
                    }
                }

                for (int k = 0; k < current.Count; k++)
                {
                    result.Insert(index + k, current[k]);
                    if (index + k != result.Count - 1)
                    {
                        if (current[k] > result[index + k + 1])
                        {
                            break;
                        }
                    }
                }

                for (int k = 0; k < result.Count - 1; k++)
                {
                    if (result[k] > result[k + 1])
                    {
                        result.RemoveRange(k + 1, result.Count - 1 - k);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

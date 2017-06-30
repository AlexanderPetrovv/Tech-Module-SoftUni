using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombStats = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bombNum = bombStats[0];
            int bombPower = bombStats[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bombNum)
                {
                    int leftIndex = Math.Max(i - bombPower, 0);
                    int rightIndex = Math.Min(i + bombPower, numbers.Count - 1);

                    int removeCnt = rightIndex - leftIndex + 1;

                    numbers.RemoveRange(leftIndex, removeCnt);
                    i = -1;
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}

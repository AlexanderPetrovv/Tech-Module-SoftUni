using System;
using System.Linq;

namespace Wormhole
{
    class Wormhole
    {
        static void Main(string[] args)
        {
            int[] wormholes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int steps = 0;
            for (int i = 0; i < wormholes.Length; i++)
            {
                if (wormholes[i] != 0)
                {
                    int index = wormholes[i] - 1;
                    wormholes[i] = 0;
                    i = index;
                }
                else
                {
                    steps++;
                }
            }
            Console.WriteLine(steps);
        }
    }
}

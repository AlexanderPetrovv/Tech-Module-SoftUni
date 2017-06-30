using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            var peshoKickDmg = int.Parse(Console.ReadLine());
            var goshoFistDmg = int.Parse(Console.ReadLine());

            var peshoHp = 100;
            var goshoHp = 100;
            var roundCnt = 0;

            while (true)
            {
                roundCnt++;
                if (roundCnt % 2 == 1)
                {
                    goshoHp -= peshoKickDmg;
                    if (goshoHp <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                    }
                }
                else if (roundCnt % 2 == 0)
                {
                    peshoHp -= goshoFistDmg;
                    if (peshoHp <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                    }
                }

                if (roundCnt % 3 == 0)
                {
                    goshoHp += 10;
                    peshoHp += 10;
                }
            }

            if (goshoHp > 0)
            {
                Console.WriteLine($"Gosho won in {roundCnt}th round.");
            }
            else if (peshoHp > 0)
            {
                Console.WriteLine($"Pesho won in {roundCnt}th round.");
            }
        }
    }
}

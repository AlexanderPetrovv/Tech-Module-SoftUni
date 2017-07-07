using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            List<int> cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] player = Console.ReadLine().Split(' ').ToArray();

            int index = cylinder.IndexOf(1);
            bool isDead = false;
            for (int p = 0; p < player.Length; p++)
            {
                string[] token = player[p].Split(',').ToArray();
                int str = int.Parse(token[0]);
                string direction = token[1];
                
                if (direction == "Left")
                {
                    for (int i = 0; i < str; i++)
                    {
                        index--;
                        if (index < 0)
                        {
                            index = cylinder.Count - 1;
                        }
                    }
                }
                else if(direction == "Right")
                {
                    index = (index + str) % cylinder.Count;
                }

                if (index == 2)
                {
                    Console.WriteLine($"Game over! Player {p} is dead.");
                    isDead = true;
                    break;
                }
                else
                {
                    index = index + 1 == cylinder.Count ? 0 : index + 1;
                }
            }

            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}

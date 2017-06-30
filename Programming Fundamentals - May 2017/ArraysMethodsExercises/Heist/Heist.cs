using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heist
{
    class Heist
    {
        static void Main(string[] args)
        {
            int[] jewelGoldPrices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            long jewelEarnings = 0;
            long goldEarnings = 0;
            long totalExpenses = 0;

            while (command != "Jail Time")
            {
                string[] cmd = command.Split();
                for (int i = 0; i < cmd[0].Length; i++)
                {
                    if (cmd[0][i] == '%')
                    {
                        jewelEarnings += jewelGoldPrices[0];
                    }
                    else if (cmd[0][i] == '$')
                    {
                        goldEarnings += jewelGoldPrices[1];
                    }
                }
                totalExpenses += long.Parse(cmd[1]);
                command = Console.ReadLine();
            }

            long totalEarnings = jewelEarnings + goldEarnings;
            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}

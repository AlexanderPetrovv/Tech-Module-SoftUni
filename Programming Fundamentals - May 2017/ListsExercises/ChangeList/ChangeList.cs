using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                List<string> cmd = command.Split().ToList();
                if (cmd[0] == "Delete")
                {
                    int delNum = int.Parse(cmd[1]);
                    nums.RemoveAll(item => item == delNum);
                }
                else if (cmd[0] == "Insert")
                {
                    int insertPos = int.Parse(cmd[2]);
                    int insertValue = int.Parse(cmd[1]);

                    nums.Insert(insertPos, insertValue);
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if (Math.Abs(nums[i]) % 2 == 0 && command == "Even")
                {
                    Console.Write(nums[i] + " ");
                }
                else if (Math.Abs(nums[i]) % 2 == 1 && command == "Odd")
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

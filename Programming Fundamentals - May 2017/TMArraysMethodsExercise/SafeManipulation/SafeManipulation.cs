using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] cmd = command.Split();

                switch (cmd[0])
                {
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;
                    case "Reverse":
                        Array.Reverse(arr);
                        break;
                    case "Replace":
                        int replaceIndex = int.Parse(cmd[1]);
                        string replaceValue = cmd[2];
                        if (replaceIndex < arr.Length && replaceIndex > -1)
                        {
                            arr[replaceIndex] = replaceValue; 
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

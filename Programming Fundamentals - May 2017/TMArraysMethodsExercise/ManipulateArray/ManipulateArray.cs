using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int numOfLines = int.Parse(Console.ReadLine());

            while (numOfLines > 0)
            {
                string[] cmd = Console.ReadLine().Split();
                arr = PerformAction(arr, cmd);
                numOfLines--;
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        static string[] LeaveUniqueElementsOnly(string[] arr)
        {
            arr = arr.Distinct().ToArray();
            return arr;
        }

        static void ReverseArray(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var oldElement = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = oldElement;
            }
        }

        static void ReplaceArrayElement(string[] arr, string value, int position)
        {
            arr[position] = value;
        }

        static string[] PerformAction(string[] arr, string[] command)
        {
            switch (command[0])
            {
                case "Distinct":
                    arr = LeaveUniqueElementsOnly(arr);
                    break;
                case "Reverse":
                    ReverseArray(arr);
                    break;
                case "Replace":
                    int position = int.Parse(command[1]);
                    string value = command[2];
                    ReplaceArrayElement(arr, value, position);
                    break;
            }
            return arr;
        }
    }
}

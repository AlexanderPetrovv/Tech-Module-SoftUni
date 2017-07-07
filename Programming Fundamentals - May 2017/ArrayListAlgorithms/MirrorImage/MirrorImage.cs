using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string line = Console.ReadLine();

            while (line != "Print")
            {
                int index = int.Parse(line);

                // reverse left part 
                for (int i = 0; i < index / 2; i++)
                {
                    string temp = input[i];
                    input[i] = input[index - 1 - i];
                    input[index - 1 - i] = temp;
                }

                // reverse right part
                int rightPartLen = input.Length - index - 1;
                for (int i = 0; i < rightPartLen / 2; i++)
                {
                    string temp = input[i + index + 1];
                    input[i + index + 1] = input[input.Length - i - 1];
                    input[input.Length - i - 1] = temp;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

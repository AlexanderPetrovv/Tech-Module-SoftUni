using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string[] filtered = input.Where(x => x.Length == 2).ToArray();
            string[] reversed = new string[filtered.Length];

            for (int i = 0; i < filtered.Length; i++)
            {
                string element = filtered[i];
                string swapedElemenets = new string(element.ToCharArray().Reverse().ToArray());
                reversed[i] = swapedElemenets;
            }

            foreach (var item in reversed.Reverse())
            {
                var itemToChar = Convert.ToChar(Convert.ToUInt32(item, 16));
                Console.Write(itemToChar);
            }
            Console.WriteLine();
        }
    }
}

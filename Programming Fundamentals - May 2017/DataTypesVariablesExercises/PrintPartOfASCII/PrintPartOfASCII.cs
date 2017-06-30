using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfASCII
{
    class PrintPartOfASCII
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (int num = startIndex; num <= endIndex; num++)
            {
                Console.Write((char)num + " ");
            }
            Console.WriteLine();
        }
    }
}

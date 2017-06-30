using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            for (char n1 = firstLetter; n1 <= secondLetter; n1++)
            {
                for (char n2 = firstLetter; n2 <= secondLetter; n2++)
                {
                    for (char n3 = firstLetter; n3 <= secondLetter; n3++)
                    {
                        if (n1 == skipLetter || n2 == skipLetter || n3 == skipLetter)
                        {
                            continue;
                        }
                        Console.Write($"{n1}{n2}{n3} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

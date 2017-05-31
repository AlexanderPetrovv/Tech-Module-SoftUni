using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            var inputNum = int.Parse(Console.ReadLine());

            var cnt = 0;

            for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
            {
                for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
                {
                    for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                    {
                        cnt++;
                        if (firstLetter + secondLetter + thirdLetter >= inputNum)
                        {
                            Console.Write("O" + ("" + firstLetter + secondLetter + thirdLetter)
                                .Replace('1','A')
                                .Replace('2', 'C')
                                .Replace('3', 'G')
                                .Replace('4', 'T') + "O ");
                        }
                        else
                        {
                            Console.Write("X" + ("" + firstLetter + secondLetter + thirdLetter)
                                .Replace('1', 'A')
                                .Replace('2', 'C')
                                .Replace('3', 'G')
                                .Replace('4', 'T') + "X ");
                        }

                        if (cnt % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

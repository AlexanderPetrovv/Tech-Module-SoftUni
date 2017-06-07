using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You will receive n lines. On those lines, you will receive one of the following:
 - Opening bracket – “(“,
 - Closing bracket – “)” or
 - Random string
Your task is to find out if the brackets are balanced.
That means after every closing bracket should follow an opening one.
Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced.
*/

namespace BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());

            int openBracketCnt = 0;
            int closeBracketCnt = 0;

            while (numOfLines > 0)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openBracketCnt++;
                    if (openBracketCnt - closeBracketCnt > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input == ")")
                {
                    closeBracketCnt++;
                    if (openBracketCnt - closeBracketCnt != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                numOfLines--;
            }

            Console.WriteLine(openBracketCnt != closeBracketCnt ? "UNBALANCED" : "BALANCED");
        }
    }
}

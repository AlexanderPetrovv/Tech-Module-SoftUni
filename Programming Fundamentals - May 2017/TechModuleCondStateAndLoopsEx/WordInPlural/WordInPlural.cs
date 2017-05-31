using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class WordInPlural
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word = word + "ies";
            }
            else if (word.EndsWith("o") ||
                word.EndsWith("ch") ||
                word.EndsWith("s") ||
                word.EndsWith("sh") ||
                word.EndsWith("x") ||
                word.EndsWith("z"))
            {
                word = word + "es";
            }
            else
            {
                word = word + "s";
            }

            Console.WriteLine(word);
        }
    }
}

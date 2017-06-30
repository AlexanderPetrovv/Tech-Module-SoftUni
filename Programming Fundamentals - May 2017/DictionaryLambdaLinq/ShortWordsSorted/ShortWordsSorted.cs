using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> text = Console.ReadLine().ToLower().Split(separator).ToList();

            var result = text.Where(word => word != "").Where(word => word.Length < 5).OrderBy(word => word).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

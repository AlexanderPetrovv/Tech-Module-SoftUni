using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string line = Console.ReadLine();

            /* The input will always be valid.
             You don’t need to explicitly check if you’re inserting an element into a valid index.*/

            while (line != "end")
            {
                int num = int.Parse(line);
                int index = GetInsertIndex(num);

                InsertIndexInList(index, num, numbers);

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void InsertIndexInList(int index, int num, List<int> numbers)
        {
            numbers.Insert(index, num);
        }

        static int GetInsertIndex(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }
            return num;
        }
    }
}

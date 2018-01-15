using System;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            string target = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(target);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(target, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}

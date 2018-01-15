using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write(String.Format("\\u{0:x4}", (int)ch));
            }
            Console.WriteLine();
        }
    }
}

using System;

namespace FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] conditions = Console.ReadLine().Split(' ');
            char letter = char.Parse(conditions[0]);
            int occurence = int.Parse(conditions[1]);

            int index = -1;
            for (int i = 0; i < occurence; i++)
            {
                index = text.IndexOf(letter, index + 1);
            }

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}

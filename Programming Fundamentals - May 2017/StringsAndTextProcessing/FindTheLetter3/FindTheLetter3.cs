using System;

namespace FindTheLetter3
{
    class FindTheLetter3
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split();
            string letter = tokens[0];
            int occurences = int.Parse(tokens[1]);

            int index = -1;
            do
            {
                occurences--;
                index = text.IndexOf(letter, index + 1);
            } while (index != -1 && occurences > 0);

            Console.WriteLine(index != -1 ? index.ToString() : "Find the letter yourself!");
        }
    }
}

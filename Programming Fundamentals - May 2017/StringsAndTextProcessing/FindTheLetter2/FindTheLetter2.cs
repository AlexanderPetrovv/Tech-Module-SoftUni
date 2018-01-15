using System;

namespace FindTheLetter2
{
    class FindTheLetter2
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] tokens = Console.ReadLine().Split();
            char letter = char.Parse(tokens[0]);
            int occurences = int.Parse(tokens[1]);

            int index = -1;
            int count = 0;
            char[] textArr = text.ToCharArray();
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i] == letter)
                {
                    count++;
                    if (count == occurences)
                    {
                        index = i;
                        break;
                    }
                }
            }

            Console.WriteLine(index != -1 ? index.ToString() : "Find the letter yourself!");
        }
    }
}

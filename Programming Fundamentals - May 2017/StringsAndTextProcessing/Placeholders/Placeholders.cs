using System;

namespace Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputTokens = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string text = inputTokens[0].Trim();
                string[] elements = inputTokens[1].Trim().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string placeholder = "{" + i + "}";
                    text = text.Replace(placeholder, elements[i]);
                }

                Console.WriteLine(text);

                input = Console.ReadLine();
            }
        }
    }
}

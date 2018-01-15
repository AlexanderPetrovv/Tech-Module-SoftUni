using System;

namespace SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string delimiter = Console.ReadLine();

            string[] resultText = text.Split(new string[] { delimiter }, StringSplitOptions.None);

            Console.WriteLine("[{0}]", string.Join(", ", resultText));
        }
    }
}

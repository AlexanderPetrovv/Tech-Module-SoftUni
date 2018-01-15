using System;

namespace MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();            

            while (pattern != String.Empty)
            {
                int patternIndex = input.IndexOf(pattern);
                int patternLastIndex = input.LastIndexOf(pattern);
                int indexDiff = patternLastIndex - patternIndex;

                if (patternIndex != -1 && indexDiff >= pattern.Length)
                {
                    input = input.Remove(patternLastIndex, pattern.Length).Remove(patternIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            if (pattern == String.Empty)
            {
                Console.WriteLine("No shake.");
            }
            Console.WriteLine(input);
        }
    }
}

using System;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];

            var sum = MultiplyCharacters(first, second);
            Console.WriteLine(sum);
        }

        static object MultiplyCharacters(string first, string second)
        {
            int index = 0;
            int sum = 0;
            while (index < first.Length && index < second.Length)
            {
                sum += first[index] * second[index];
                index++;
            }

            while (index < first.Length)
            {
                sum += first[index];
                index++;
            }

            while (index < second.Length)
            {
                sum += second[index];
                index++;
            }
            return sum;
        }
    }
}

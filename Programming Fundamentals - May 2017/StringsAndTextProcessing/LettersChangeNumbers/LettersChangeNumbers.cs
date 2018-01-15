using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] inputElements = Console.ReadLine().Split().Where(x => x != string.Empty).ToArray(); // A12b s17G

            double totalSum = 0;

            foreach (var element in inputElements)
            {
                double elementSum = 0;
                char firstChar = element.First();
                char lastChar = element.Last();
                double number = double.Parse(element.Substring(1, element.Length - 2));

                if (char.IsUpper(firstChar))
                {
                    elementSum += number / (firstChar - 64);
                }
                else if (char.IsLower(firstChar))
                {
                    elementSum += number * (firstChar - 96);
                }

                if (char.IsUpper(lastChar))
                {
                    elementSum -= (lastChar - 64); 
                }
                else if (char.IsLower(lastChar))
                {
                    elementSum += (lastChar - 96);
                }

                totalSum += elementSum;
            }

            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}

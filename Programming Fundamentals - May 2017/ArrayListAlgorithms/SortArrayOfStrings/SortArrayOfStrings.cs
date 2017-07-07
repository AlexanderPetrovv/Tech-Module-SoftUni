using System;
using System.Linq;


namespace SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0)
                {
                    if (input[j].CompareTo(input[j - 1]) < 0)
                    {
                        string temp = input[j];
                        input[j] = input[j - 1];
                        input[j - 1] = temp;
                    }
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}

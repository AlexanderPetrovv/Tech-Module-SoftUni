using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Extremums
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();

            switch (command)
            {
                case "Max":
                    string maxElement;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        maxElement = numbers[i];
                        for (int j = 1; j < maxElement.Length; j++)
                        {
                            string temp = numbers[i] + numbers[i];
                            string current = temp.Substring(j, maxElement.Length);

                            if (int.Parse(current) > int.Parse(maxElement))
                            {
                                maxElement = current;
                            }
                        }
                        numbers[i] = maxElement;
                    }
                    break;
                case "Min":
                    string minElement;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        minElement = numbers[i];
                        for (int j = 1; j <= minElement.Length; j++)
                        {
                            string temp = numbers[i] + numbers[i];
                            string current = temp.Substring(j, minElement.Length);

                            if (int.Parse(current) < int.Parse(minElement))
                            {
                                minElement = current;
                            }
                        }
                        numbers[i] = minElement;
                    }
                    break;
            }

            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = int.Parse(numbers[i]);
            }
            Console.WriteLine(string.Join(", ", result));
            long sum = result.Sum();
            Console.WriteLine(sum);
        }
    }
}

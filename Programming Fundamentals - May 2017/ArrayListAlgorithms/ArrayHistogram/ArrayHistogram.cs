using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            List<string> words = new List<string>();
            List<int> occurrences = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!words.Contains(input[i]))
                {
                    words.Add(input[i]);
                    occurrences.Add(1);
                }
                else
                {
                    int index = words.IndexOf(input[i]);
                    occurrences[index]++;
                }
            }

            for (int i = 0; i < words.Count - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (occurrences[j] > occurrences[j - 1])
                    {
                        int tempOcc = occurrences[j];
                        occurrences[j] = occurrences[j - 1];
                        occurrences[j - 1] = tempOcc;


                        string tempWord = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = tempWord;
                    }
                    j--;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (double)occurrences[i] / input.Length * 100.0;
                Console.WriteLine($"{words[i]} -> {occurrences[i]} times ({percentage:F2}%)");
            }
        }
    }
}

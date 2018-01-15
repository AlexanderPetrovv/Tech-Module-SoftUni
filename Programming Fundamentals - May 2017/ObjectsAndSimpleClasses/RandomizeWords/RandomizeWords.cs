using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            //Fisher–Yates shuffle

            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                int randomPos = rnd.Next(0, words.Length);

                string temp = words[randomPos];
                words[randomPos] = currentWord;
                words[i] = temp;
            }

            words.ToList().ForEach(Console.WriteLine);
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }
}

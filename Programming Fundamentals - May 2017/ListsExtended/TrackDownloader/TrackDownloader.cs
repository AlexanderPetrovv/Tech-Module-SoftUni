using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine().Split().ToList();

            string line = Console.ReadLine();
            List<string> finalList = new List<string>();
           
            while (line != "end")
            {
                bool hasBannedWord = false;
                for (int i = 0; i < bannedWords.Count; i++)
                {
                    if (line.Contains(bannedWords[i]))
                    {
                        hasBannedWord = true;
                        break;
                    }
                }

                if (!hasBannedWord)
                {
                    finalList.Add(line);
                }

                line = Console.ReadLine();
            }

            finalList.Sort();
            Console.WriteLine(string.Join("\r\n", finalList));

        }
    }
}

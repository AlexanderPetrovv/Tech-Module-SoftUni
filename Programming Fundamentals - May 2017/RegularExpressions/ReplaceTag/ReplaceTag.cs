using System;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
    class ReplaceTag
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";

            string input = Console.ReadLine();

            while (input != "end")
            {
                string replaced = Regex.Replace(input, pattern, replacement);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}

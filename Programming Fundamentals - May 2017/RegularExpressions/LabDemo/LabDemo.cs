using System;
using System.Text.RegularExpressions;

namespace LabDemo
{
    class LabDemo
    {
        static void Main(string[] args)
        {
            string[] tokens = Regex.Split("Random sentence to test,,,,,,,, spliting with regex", @"\W+");
            Console.WriteLine(string.Join(Environment.NewLine, tokens));

            string[] arr = Regex.Split("Random sentence to test,,,,,,,, spliting with regex", @"[,.!\- ]+");
            Console.WriteLine(string.Join(Environment.NewLine, arr));

            var matches = Regex.Matches("Random sentence to test,,,,,,,, spliting with regex", @"\w+");
            foreach (var match in matches)
            {
                Console.WriteLine(match);
                Console.WriteLine(((Match)match).Index);   // Word indexes
            }

            Regex regex = new Regex(Regex.Escape(Console.ReadLine()));
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace HappinessIndex
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex(@"(\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\;\}|\:\}|\(\:|\*\:|c\:|\[\:|\[\;)");
            Regex sadPattern = new Regex(@"(\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;)");

            string input = Console.ReadLine();

            double happyIconsCnt = happyPattern.Matches(input).Count;
            double sadIconsCnt = sadPattern.Matches(input).Count;

            double happinessIndex = happyIconsCnt / sadIconsCnt;
            string mood = CalcMood(happinessIndex);

            Console.WriteLine("Happiness index: {0:F2} {1}", happinessIndex, mood);
            Console.WriteLine($"[Happy count: {happyIconsCnt}, Sad count: {sadIconsCnt}]");
        }

        static string CalcMood(double happinessIndex)
        {
            string mood = string.Empty;

            if (happinessIndex >= 2)
            {
                return ":D";
            }
            else if (happinessIndex > 1)
            {
                return ":)";
            }
            else if (happinessIndex == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace PhoenixGrid
{
    class PhoenixGrid
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^([^\s_]{3})(\.[^\s_]{3})*$");

            string input;

            while ((input = Console.ReadLine()) != "ReadMe")
            {
                if (IsValid(regex, input) && IsPalindrome(input))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static bool IsValid(Regex regex, string input)
        {
            return regex.IsMatch(input);
        }

        static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

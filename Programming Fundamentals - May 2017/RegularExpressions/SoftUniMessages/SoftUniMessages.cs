using System;
using System.Text.RegularExpressions;

namespace SoftUniMessages
{
    class SoftUniMessages
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]+$");

            string input = Console.ReadLine();

            while (input != "Decrypt!")
            {
                int validLength = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string message = match.Groups["message"].Value;

                    if (message.Length == validLength)
                    {
                        string decryptedMessage = DecryptMessage(input, message);

                        Console.WriteLine($"{message} = {decryptedMessage}");
                    }
                }
                input = Console.ReadLine();
            }
        }

        static string DecryptMessage(string input, string message)
        {
            string result = string.Empty;

            foreach (char ch in input)
            {
                int index = ch - '0';
                if (char.IsDigit(ch) && index < message.Length)
                {
                    result += message[index];
                }
            }
            return result;
        }
    }
}

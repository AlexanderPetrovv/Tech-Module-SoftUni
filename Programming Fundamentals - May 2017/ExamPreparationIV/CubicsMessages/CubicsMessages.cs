using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CubicsMessages
{
    class CubicsMessages
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();                     

            while (line != "Over!")
            {
                int length = int.Parse(Console.ReadLine());

                Regex regex = new Regex(@"^\d+(?<message>[a-zA-Z]{" + length + @"})[^a-zA-Z]*$");

                if (regex.IsMatch(line))
                {
                    Match match = regex.Match(line);

                    string message = match.Groups["message"].Value;

                    StringBuilder builder = new StringBuilder();

                    foreach (var ch in line)
                    {
                        if (char.IsDigit(ch))
                        {
                            if ((ch - '0' >= 0 && ch - '0' < message.Length))
                            {
                                builder.Append(message[ch - '0']);
                            }
                            else
                            {
                                builder.Append(' ');
                            }                            
                        }                       
                    }

                    Console.WriteLine(message + " == " + builder.ToString());
                }

                line = Console.ReadLine();
            }
        }
    }
}

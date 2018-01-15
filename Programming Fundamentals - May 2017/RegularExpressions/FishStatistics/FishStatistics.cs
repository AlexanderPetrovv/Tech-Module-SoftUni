using System;
using System.Text.RegularExpressions;

namespace FishStatistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            Regex fishRegex = new Regex(@">*<\(+['\-x]>");

            string input = Console.ReadLine();

            MatchCollection fishes = fishRegex.Matches(input);

            int fishIndex = 1;
            foreach (Match fishMatch in fishes)
            {
                string fish = fishMatch.Value;
                int tailSize = 0;
                int bodySize = 0;
                string status = string.Empty;
                
                foreach (var ch in fish)
                {
                    if (ch == '>')
                    {
                        tailSize++;
                    }
                    else if (ch == '(')
                    {
                        bodySize++;
                    }
                    else if (ch == '\'')
                    {
                        status = "Awake";
                    }
                    else if (ch == '-')
                    {
                        status = "Asleep";
                    }
                    else if (ch == 'x')
                    {
                        status = "Dead";
                    }
                }

                tailSize--; //BECAUSE FISH HEAD ALSO CONTAINS '>' SYMBOL

                string tailType = GetTailType(tailSize);
                string bodyType = GetBodyType(bodySize);

                Console.WriteLine($"Fish {fishIndex}: {fish}");
                Console.Write("  Tail type: {0}", tailType);
                if (tailType != "None")
                {
                    Console.WriteLine(" ({0} cm)", tailSize * 2);
                }
                else
                {
                    Console.WriteLine();
                }
                Console.WriteLine("  Body type: {0} ({1} cm)", bodyType, bodySize * 2);
                Console.WriteLine("  Status: {0}", status);

                fishIndex++;
            }

            if (fishIndex == 1)
            {
                Console.WriteLine("No fish found.");
            }
        }

        static string GetTailType(int tailSize)
        {
            if (tailSize > 5)
            {
                return "Long";
            }
            else if (tailSize > 1)
            {
                return "Medium";
            }
            else if (tailSize == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }

        static string GetBodyType(int bodySize)
        {
            if (bodySize > 10)
            {
                return "Long";
            }
            else if (bodySize > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }
    }
}

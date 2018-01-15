using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"\s<->\s";

            List<string> privateMessages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (!inputLine.Equals("Hornet is Green"))
            {
                string[] tokens = Regex.Split(inputLine, pattern);
                if (tokens.Length >= 2)
                {
                    string firstQuery = tokens[0];
                    string secondQuery = tokens[1];

                    if (IsPrivateMessage(firstQuery, secondQuery))
                    {
                        string recipientCode = firstQuery;
                        string recipientMessage = secondQuery;

                        string reversedCode = new string(recipientCode.Reverse().ToArray());
                        string privateMessage = reversedCode + " -> " + recipientMessage;

                        privateMessages.Add(privateMessage);
                    }
                    else if (IsBroadcast(firstQuery, secondQuery))
                    {
                        string broadcastMessage = firstQuery;
                        string frequency = secondQuery;

                        string resultFrequency = SwapLetterCases(frequency);
                        string broadcast = resultFrequency + " -> " + broadcastMessage;

                        broadcasts.Add(broadcast);
                    }
                }              

                inputLine = Console.ReadLine();
            }

            PrintOutput(privateMessages, broadcasts);

        }

        static void PrintOutput(List<string> privateMessages, List<string> broadcasts)
        {
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
            }


            Console.WriteLine("Messages:");
            if (privateMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, privateMessages));
            }
        }

        static string SwapLetterCases(string frequency)
        {
            StringBuilder resultStr = new StringBuilder();

            for (int i = 0; i < frequency.Length; i++)
            {
                if (char.IsLetter(frequency[i]))
                {
                    if (char.IsLower(frequency[i]))
                    {
                        resultStr.Append(frequency[i].ToString().ToUpper());
                        continue;
                    }
                    else if (char.IsUpper(frequency[i]))
                    {
                        resultStr.Append(frequency[i].ToString().ToLower());
                        continue;
                    }
                }
                else
                {
                    resultStr.Append(frequency[i]);
                    continue;
                }
            }
            return resultStr.ToString();
        }

        static bool IsBroadcast(string firstQuery, string secondQuery)
        {
            return !IsOnlyDigits(firstQuery) && HasOnlyDigitsAndLetters(secondQuery);
        }

        static bool IsPrivateMessage(string firstQuery, string secondQuery)
        {
            return IsOnlyDigits(firstQuery) && HasOnlyDigitsAndLetters(secondQuery);
        }

        static bool HasOnlyDigitsAndLetters(string secondQuery)
        {
            foreach (char ch in secondQuery)
            {
                if (char.IsDigit(ch))
                {
                    continue;
                }
                else if (char.IsLetter(ch))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsOnlyDigits(string firstQuery)
        {
            foreach (char ch in firstQuery)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

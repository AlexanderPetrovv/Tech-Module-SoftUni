using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SpyGram
{
    class SpyGram
    {
        static void Main(string[] args)
        {
            var messages = new Dictionary<string, List<string>>();

            string privateKey = Console.ReadLine();

            string pattern = @"^TO:\s(?<recipient>[A-Z]+);\sMESSAGE:\s(?<msg>.+);$";

            string message;

            while ((message = Console.ReadLine()) != "END")
            {
                Regex regex = new Regex(pattern);

                if (regex.IsMatch(message))
                {
                    Match match = regex.Match(message);

                    string recipient = match.Groups["recipient"].Value;
                    string msg = match.Groups["msg"].Value;

                    if (!messages.ContainsKey(recipient))
                    {
                        messages[recipient] = new List<string>();
                    }

                    int index = 0;
                    StringBuilder encryptedMsg = new StringBuilder();

                    foreach (char ch in message)
                    {
                        if (index > privateKey.Length - 1)
                        {
                            index = 0;
                        }
                        var step = int.Parse(privateKey[index++].ToString());
                        encryptedMsg.Append((char)(ch + step));
                    }

                    messages[recipient].Add(encryptedMsg.ToString());
                }
            }

            foreach (var msg in messages.OrderBy(x => x.Key))
            {
                Console.WriteLine(string.Join(Environment.NewLine, msg.Value));
            }
        }
    }
}

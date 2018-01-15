using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> accounts = new Dictionary<string, string>();

            while (input[0] != "login")
            {
                string user = input[0];
                string password = input[1];

                accounts[user] = password;

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            int failedLogs = 0;
            while (input[0] != "end")
            {              
                string user = input[0];
                string password = input[1];

                if (!accounts.ContainsKey(user) || accounts[user] != password)
                {
                    Console.WriteLine($"{user}: login failed");
                    failedLogs++;
                }
                else
                {
                    Console.WriteLine($"{user}: logged in successfully");
                }

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"unsuccessful login attempts: {failedLogs}");
        }
    }
}

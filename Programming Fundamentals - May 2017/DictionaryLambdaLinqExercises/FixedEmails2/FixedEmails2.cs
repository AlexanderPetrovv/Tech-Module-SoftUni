using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedEmails2
{
    class FixedEmails2
    {
        static void Main(string[] args)
        {
            var namesEmails = new Dictionary<string, string>();

            string line = Console.ReadLine();
            while (line != "stop")
            {
                string name = line;
                string email = Console.ReadLine();

                namesEmails[name] = email;
                line = Console.ReadLine();
            }

            var fixedEmails = namesEmails
                .Where(kvp => !(kvp.Value.EndsWith("uk") || kvp.Value.EndsWith("us")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var nameEmail in fixedEmails)
            {
                string name = nameEmail.Key;
                string email = nameEmail.Value;

                Console.WriteLine($"{name} -> {email}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                var sufixList = email.ToLower().Split('.').Reverse().Take(1).ToList();
                var sufix = sufixList[0];
                if (sufix != "uk" || sufix != "us")
                {
                    dict[name] = email;
                }
            }

            foreach (var person in dict)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var result = new Dictionary<string, DateTime>();

            while (line != "end")
            {
                string[] input = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string user = input[0];
                var date = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                result[user] = date;

                line = Console.ReadLine();
            }

            result = result
                .Reverse()
                .OrderBy(u => u.Value)
                .Take(5)
                .OrderByDescending(u => u.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var user in result)
            {
                string username = user.Key;
                Console.WriteLine(username);
            }
        }
    }
}

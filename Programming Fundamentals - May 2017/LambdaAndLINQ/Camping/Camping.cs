using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class Camping
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var register = new Dictionary<string, Dictionary<string, int>>();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');
                string name = tokens[0];
                string camperModel = tokens[1];
                int timeToStay = int.Parse(tokens[2]);

                if (!register.ContainsKey(name))
                {
                    register[name] = new Dictionary<string, int>();
                }

                if (!register[name].ContainsKey(camperModel))
                {
                    register[name][camperModel] = timeToStay;
                }

                line = Console.ReadLine();
            }

            register = register
                .OrderByDescending(x => x.Value.Count())
                .ThenBy(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var personData in register)
            {
                string name = personData.Key;
                var campersData = personData.Value;
                int campersCnt = campersData.Count();

                Console.WriteLine($"{name}: {campersCnt}");
                
                foreach (var camper in campersData)
                {
                    string camperModel = camper.Key;
                    Console.WriteLine($"***{camperModel}");
                }
                int totalNights = campersData.Sum(x => x.Value);
                Console.WriteLine($"Total stay: {totalNights} nights");
            }
        }
    }
}

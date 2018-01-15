using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public Website(string host, string domain, List<string> queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queries = queries;
        }
    }

    class Websites
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var websites = new List<Website>();

            while (line != "end")
            {
                string[] tokens = line.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string host = tokens[0];
                string domain = tokens[1];

                if (tokens.Length > 2)
                {
                    List<string> queries = tokens[2].Split(',').ToList();
                    websites.Add(new Website(host, domain, queries));
                }
                else
                {
                    websites.Add(new Website(host, domain, null));
                }

                line = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}");

                if (website.Queries != null)
                {
                    Console.Write("/query?=[" + string.Join("]&[", website.Queries) + "]");
                }
                Console.WriteLine();
            }
        }
    }
}

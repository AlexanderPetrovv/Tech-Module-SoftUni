using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            var language = "";
            switch (country.ToLower())
            {
                case "england":
                case "usa":
                    language = "English";
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] demons = inputLine
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToArray();

            Regex healthRegex = new Regex(@"[^\/\*\-\+\.\, \d]");
            Regex damageRegex = new Regex(@"([-+]?\d+\.?\d+|[-+]?\d|\/|\*)");

            foreach (var demon in demons)
            {              
                StringBuilder healthBuilder = new StringBuilder();
                Match healthMatch = healthRegex.Match(demon);
                while (healthMatch.Success)
                {
                    healthBuilder.Append(healthMatch);
                    healthMatch = healthMatch.NextMatch();
                }

                double demonHealth = 0;
                foreach (char ch in healthBuilder.ToString())
                {
                    demonHealth += ch;
                }

                double demonDamage = 0;
                int multiplyDivide = 0;
                Match damageMatch = damageRegex.Match(demon);
                while (damageMatch.Success)
                {
                    double num = 0;
                    if (double.TryParse(damageMatch.ToString(), out num))
                    {
                        demonDamage += num;
                    }
                    else
                    {
                        if (damageMatch.ToString() == "*")
                        {
                            multiplyDivide++;
                        }
                        else if (damageMatch.ToString() == "/")
                        {
                            multiplyDivide--;
                        }
                    }
                    damageMatch = damageMatch.NextMatch();
                }
                
                if (multiplyDivide > 0)
                {
                    demonDamage = demonDamage * Math.Pow(2, multiplyDivide);
                }
                else if (multiplyDivide < 0)
                {
                    demonDamage = demonDamage / (Math.Pow(2, multiplyDivide));
                }

                Console.WriteLine("{0} - {1} health, {2:F2} damage", demon, demonHealth, demonDamage);            
            }
        }
    }
}

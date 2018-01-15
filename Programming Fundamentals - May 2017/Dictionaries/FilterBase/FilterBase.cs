using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, decimal>();
            var positionDict = new Dictionary<string, string>();
            string name;
            int age;
            decimal salary;
            string position;
            while (line != "filter base")
            {
                string[] input = line.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                name = input[0];

                if (int.TryParse(input[1], out age))
                {
                    ageDict[name] = age;
                }
                else if (decimal.TryParse(input[1], out salary))
                {
                    salaryDict[name] = salary;
                }
                else
                {
                    position = input[1];
                    positionDict[name] = position;
                }

                line = Console.ReadLine();
            }

            string cmd = Console.ReadLine();
            if (cmd == "Age")
            {
                foreach (KeyValuePair<string, int> employee in ageDict)
                {
                    Console.WriteLine("Name: {0}", employee.Key);
                    Console.WriteLine("Age: {0}", employee.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (cmd == "Salary")
            {
                foreach (KeyValuePair<string, decimal> employee in salaryDict)
                {
                    Console.WriteLine("Name: {0}", employee.Key);
                    Console.WriteLine("Salary: {0:F2}", employee.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (cmd == "Position")
            {
                foreach (KeyValuePair<string, string> employee in positionDict)
                {
                    Console.WriteLine("Name: {0}", employee.Key);
                    Console.WriteLine("Position: {0}", employee.Value);
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}

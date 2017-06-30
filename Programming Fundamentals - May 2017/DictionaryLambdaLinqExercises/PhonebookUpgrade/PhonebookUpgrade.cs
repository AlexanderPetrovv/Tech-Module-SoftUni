using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();

            while (command != "END")
            {
                string[] cmd = command.Split();
                string condition = cmd[0];
                string name = String.Empty;
                string number = String.Empty;
                if (cmd.Length == 2)
                {
                    name = cmd[1];             
                }
                else if (cmd.Length == 3)
                {
                    name = cmd[1];
                    number = cmd[2];
                }

                switch (condition)
                {
                    case "A":
                        phonebook[name] = number;
                        break;
                    case "S":
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var element in phonebook)
                        {
                            Console.WriteLine($"{element.Key} -> {element.Value}");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}

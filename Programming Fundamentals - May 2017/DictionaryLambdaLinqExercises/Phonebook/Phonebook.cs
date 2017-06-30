using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] cmd = command.Split();
                string condition = cmd[0];
                string name = cmd[1];
                string number = String.Empty;
                if (cmd.Length > 2)
                {
                    number = cmd[2];
                }
                if (condition == "A")
                {
                    phonebook[name] = number;
                }
                else if (condition == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatabase
{    
    class UserDatabase
    {
        private static string databaseFile = "users.txt";
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private static string loggedUser = null;

        static void Main(string[] args)
        {
            if (!File.Exists(databaseFile))
            {
                File.Create(databaseFile).Close();
            }

            // LOAD ALL AVAILABLE USERS FROM DATABASE

            string[] dbLines = File.ReadAllLines(databaseFile);

            foreach (var line in dbLines)
            {
                string[] lineTokens = line.Split(' ');
                string username = lineTokens[0];
                string password = lineTokens[1];

                users[username] = password;
            }

            string[] commands = File.ReadAllLines("Input.txt");

            foreach (string command in commands)
            {
                string[] commandTokens = command.Split(' ');

                switch (commandTokens[0])
                {
                    case "register":
                        string username = commandTokens[1];
                        string password = commandTokens[2];
                        string confirmPassword = commandTokens[3];
                        Register(username, password, confirmPassword);
                        break;
                    case "login":
                        username = commandTokens[1];
                        password = commandTokens[2];
                        Login(username, password);
                        break;
                    case "logout":
                        Logout();
                        break;
                }
            }
        }

        static void Register(string username, string password, string confirmPassword)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }

            if (password != confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }

            users[username] = password;

            File.AppendAllLines(databaseFile, new[] { $"{username} {password}" });
        }

        static void Login(string username, string password)
        {
            if (loggedUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }

            if (users[username] != password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }

            loggedUser = username;
        }

        static void Logout()
        {
            if (loggedUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }

            loggedUser = null;
        }
    }
}

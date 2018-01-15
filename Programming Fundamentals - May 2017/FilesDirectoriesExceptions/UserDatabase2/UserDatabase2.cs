using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDatabase2
{
    class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsLogged { get; set; }
    }

    class UserDatabase2
    {
        static void Main(string[] args)
        {
            string database = "users.txt";

            var users = new Dictionary<string, User>();

            string[] data = File.ReadAllLines(database);

            foreach (string userData in data)
            {
                string[] userTokens = userData.Split(' ');

                User user = new User
                {
                    Username = userTokens[0],
                    Password = userTokens[1],
                    IsLogged = bool.Parse(userTokens[2])
                };

                users.Add(user.Username, user);
            }

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                if (tokens[0] == "exit")
                {
                    break;
                }

                switch (tokens[0])
                {
                    case "register":
                        string username = tokens[1];
                        string password = tokens[2];
                        string confirmPass = tokens[3];

                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                        else if (password != confirmPass)
                        {
                            Console.WriteLine("The two passwords must match");
                        }
                        else
                        {
                            User userToReg = new User
                            {
                                Username = username,
                                Password = password,
                                IsLogged = false
                            };

                            users.Add(userToReg.Username, userToReg);
                        }
                    break;
                    case "login":
                        username = tokens[1];
                        password = tokens[2];
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (users[username].IsLogged)
                        {
                            Console.WriteLine("There is already a logged in user.");
                        }
                        else if (users[username].Password != password)
                        {
                            Console.WriteLine("The password you entered is incorrect.");
                        }
                        else
                        {
                            users[username].IsLogged = true;
                        }
                    break;
                    case "logout":
                        username = tokens[1];
                        if(!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (!users[username].IsLogged)
                        {
                            Console.WriteLine($"User {username} is not logged in.");
                        }
                        else
                        {
                            users[username].IsLogged = false;
                        }
                    break;
                }
            }

            foreach (KeyValuePair<string, User> user in users)
            {
                File.WriteAllLines(database, users
                    .Values
                    .Select(u => $"{u.Username} {u.Password} {u.IsLogged}")
                    .ToArray());
            }
        }
    }
}

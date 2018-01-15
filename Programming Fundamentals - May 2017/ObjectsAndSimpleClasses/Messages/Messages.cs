using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    class User
    {
        public User(string username)
        {
            this.Username = username;
            this.ReceivedMessages = new List<Message>();
        }

        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }
    }

    class Message
    {
        public Message(string content, User sender)
        {
            this.Content = content;
            this.Sender = sender;
        }

        public string Content { get; set; }
        public User Sender { get; set; }
    }

    class Messages
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var users = new Dictionary<string, User>();

            while (line != "exit")
            {
                string[] tokens = line.Split(' ');

                if (tokens[0] == "register")
                {
                    string username = tokens[1];
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new User(username));
                    }
                }
                else
                {
                    string sender = tokens[0];
                    string recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        users[recipient].ReceivedMessages.Add(new Message(content, users[sender]));
                    }
                }

                line = Console.ReadLine();
            }

            string[] people = Console.ReadLine().Split(' ');
            string firstPerson = people[0];
            string secondPerson = people[1];

            Message[] firstPersonMessages = users[secondPerson]
                .ReceivedMessages
                .Where(m => m.Sender.Username == firstPerson)
                .ToArray();

            Message[] secondPersonMessages = users[firstPerson]
                .ReceivedMessages
                .Where(m => m.Sender.Username == secondPerson)
                .ToArray();

            if (firstPersonMessages.Length == 0 && secondPersonMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {
                int maxLength = Math.Max(firstPersonMessages.Length, secondPersonMessages.Length);

                for (int i = 0; i < maxLength; i++)
                {
                    if (i < firstPersonMessages.Length)
                    {
                        Console.WriteLine($"{firstPersonMessages[i].Sender.Username}: {firstPersonMessages[i].Content}");
                    }

                    if (i < secondPersonMessages.Length)
                    {
                        Console.WriteLine($"{secondPersonMessages[i].Content} :{secondPersonMessages[i].Sender.Username}");
                    }
                }
            }
        }
    }
}

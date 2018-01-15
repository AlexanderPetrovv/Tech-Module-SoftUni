using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages2
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

    class Messages2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, User>();

            while (!input.Equals("exit"))
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    string username = tokens[1];

                    if (!users.ContainsKey(username))
                    {
                        User user = new User(username);
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
                        Message message = new Message(content, users[sender]);
                        users[recipient].ReceivedMessages.Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] chatTokens = input.Split(' ');
            string firstUser = chatTokens[0];
            string secondUser = chatTokens[1];

            Message[] firstUserMessages = users[secondUser]
                .ReceivedMessages
                .Where(m => m.Sender.Username == firstUser)
                .ToArray();

            Message[] secondUserMessages = users[firstUser]
                .ReceivedMessages
                .Where(m => m.Sender.Username == secondUser)
                .ToArray();

            if (firstUserMessages.Count() == 0 && secondUserMessages.Count() == 0)
            {
                Console.WriteLine("No messages");
            }

            int index = 0;
            while (index < firstUserMessages.Length && index < secondUserMessages.Length)
            {
                Console.WriteLine("{0}: {1}",
                    firstUserMessages[index].Sender.Username,
                    firstUserMessages[index].Content);

                Console.WriteLine("{0} :{1}",
                    secondUserMessages[index].Content,
                    secondUserMessages[index].Sender.Username);

                index++;
            }

            while (index < secondUserMessages.Length)
            {
                Console.WriteLine("{0} :{1}",
                    secondUserMessages[index].Content,
                    secondUserMessages[index].Sender.Username);

                index++;
            }

            while (index < firstUserMessages.Length)
            {
                Console.WriteLine("{0}: {1}",
                    firstUserMessages[index].Sender.Username,
                    firstUserMessages[index].Content);

                index++;
            }
        }
    }
}

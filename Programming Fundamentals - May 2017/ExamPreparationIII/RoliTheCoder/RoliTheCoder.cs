using System;
using System.Collections.Generic;
using System.Linq;

namespace RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var eventsIds = new Dictionary<int, string>();
            var eventsParticipants = new Dictionary<string, SortedSet<string>>();

            while (!line.Equals("Time for Code"))
            {
                string[] tokens = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int idCode = int.Parse(tokens[0]);
                string eventName = tokens[1];
                string[] participants = tokens.Skip(2).ToArray();

                if (eventName[0] == '#')
                {
                    if (!eventsIds.ContainsKey(idCode))
                    {
                        eventsIds[idCode] = eventName;
                        eventsParticipants[eventName] = new SortedSet<string>(participants);
                    }
                    else
                    {
                        if (eventsIds[idCode] == eventName)
                        {
                            foreach (var participant in participants)
                            {
                                eventsParticipants[eventName].Add(participant);
                            }
                        }
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var @event in eventsParticipants.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} - {1}", @event.Key.TrimStart('#'), @event.Value.Count);

                SortedSet<string> participants = @event.Value;
                foreach (string participant in participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}

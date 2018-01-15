using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var result = new Dictionary<string, HashSet<string>>();

            while (line != "filter")
            {
                string[] input = line
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string topic = input[0];
                string[] tags = input[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!result.ContainsKey(topic))
                {
                    result[topic] = new HashSet<string>();
                }

                foreach (string tag in tags)
                {
                    result[topic].Add(tag);
                }

                line = Console.ReadLine();
            }

            string[] targetTags = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (KeyValuePair<string, HashSet<string>> topicTags in result)
            {
                string topic = topicTags.Key;
                HashSet<string> tags = topicTags.Value;

                bool containsAll = true;
                foreach (string targetTag in targetTags)
                {                  
                    if (!tags.Contains(targetTag))
                    {
                        containsAll = false;
                        break;
                    }
                }

                if (containsAll)
                {
                    Console.Write($"{topic} | ");
                    bool isFirst = true;
                    foreach (string tag in tags)
                    {
                        if (isFirst)
                        {
                            Console.Write($"#{tag}");
                            isFirst = false;
                            continue;
                        }
                        Console.Write($", #{tag}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLContents
{
    class HTMLContents
    {
        static void Main(string[] args)
        {
            string file = "index.html";

            File.WriteAllText(file, "<!DOCTYPE html>" + Environment.NewLine);
            File.AppendAllText(file, "<html>" + Environment.NewLine);
            File.AppendAllText(file, "<head>" + Environment.NewLine);

            string title = String.Empty;
            List<string[]> bodyContent = new List<string[]>();

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                if (tokens[0] == "exit")
                {
                    break;
                }                
                else if (tokens[0] == "title")
                {
                    title = tokens[1];                  
                }
                else
                {
                    bodyContent.Add(tokens);
                }
            }
            File.AppendAllText(file, $"\t<title>{title}</title>");
            File.AppendAllText(file, "</head>" + Environment.NewLine);
            File.AppendAllText(file, "<body>" + Environment.NewLine);

            foreach (string[] tagData in bodyContent)
            {
                string tag = tagData[0];
                string content = tagData[1];
                File.AppendAllText(file, $"\t<{tag}>{content}</{tag}>");
            }

            File.AppendAllText(file, "</body>" + Environment.NewLine);
            File.AppendAllText(file, "</html>" + Environment.NewLine);
        }
    }
}

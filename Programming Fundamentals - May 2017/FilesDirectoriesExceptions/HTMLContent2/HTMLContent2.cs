using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLContent2
{
    class HTMLContent2
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            string title = String.Empty;
            List<string> bodyParts = new List<string>();

            foreach (var line in lines)
            {
                if (line == "exit")
                {
                    break;
                }

                string[] lineParams = line.Split(' ');
                string tag = lineParams[0];
                string content = lineParams[1];

                if (tag == "title")
                {
                    title = content;
                }
                else
                {
                    bodyParts.Add($"\t<{tag}>{content}</{tag}>");
                }
            }

            var result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != String.Empty)
            {
                result.AppendLine($"\t<title>{title}</title>");
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("index.html", result.ToString().Trim());
        }
    }
}

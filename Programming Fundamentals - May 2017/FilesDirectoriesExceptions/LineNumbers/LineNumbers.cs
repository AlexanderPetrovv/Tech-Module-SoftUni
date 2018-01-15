using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");
            var numberedLines = lines.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines("numberedLines.txt", numberedLines);
        }
    }
}

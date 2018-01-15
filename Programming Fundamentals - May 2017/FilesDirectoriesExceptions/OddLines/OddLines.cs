using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            // Slower way
            //string[] lines = File.ReadAllLines("Input.txt");
            //for (int i = 1; i < lines.Length; i += 2)
            //{
            //    File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            //}

            //Faster way
            string[] lines = File.ReadAllLines("Input.txt");
            string[] oddLines = lines.Where((line, index) => index % 2 == 1).ToArray();
            File.WriteAllLines("odd-lines.txt", oddLines);
        }
    }
}

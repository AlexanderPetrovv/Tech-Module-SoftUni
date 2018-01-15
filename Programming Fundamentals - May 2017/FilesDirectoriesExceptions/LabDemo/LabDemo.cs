using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDemo
{
    class LabDemo
    {
        static void Main(string[] args)
        {
            if (!File.Exists("myFile.txt"))
            {
                File.Create("myFile.txt");
            }

            //Console.Write("Hello");
            //Console.Write("\n");
            //Console.Write("there");
            //Console.Write("\r");
            //Console.Write("p");

            //for (int i = 0; i <= 150000; i++)
            //{
            //    Console.Write("\r");
            //    Console.Write("Working... 1 of " + i);
            //}
            //Console.Write("\n");

            //string text = File.ReadAllText("input.txt");
            //Console.WriteLine(text);

            //string[] lines = File.ReadAllLines("input.txt");   // If file does not exist we get FileNotFoundException
            //Console.WriteLine(string.Join(Environment.NewLine, lines));

            //File.WriteAllText("output.txt", "Files are fun :)");   // If file already exist it will overwrite it 

            //string[] names = { "Pesho", "Gosho", "Maria", "Irina" };
            //File.WriteAllLines("names.txt", names);

            //Console.WriteLine(File.ReadAllText(@"..\..\LabDemo.cs")); // reads program.cs source code with relative path

            //File.AppendAllText("output.txt", "Some text with AppendAllText");

            //byte[] bytes = File.ReadAllBytes("input.txt");
            //Console.WriteLine(string.Join("", bytes.Select(b => String.Format("{0:X}", b))));

            //var info = new FileInfo("output.txt");
            //Console.WriteLine("FIle size: {0} bytes", info.Length);
            //Console.WriteLine("Created at: {0}", info.CreationTime);
            //Console.WriteLine("Path + name: {0}", info.FullName);
            //Console.WriteLine("File extension: {0}", info.Extension);
        }
    }
}

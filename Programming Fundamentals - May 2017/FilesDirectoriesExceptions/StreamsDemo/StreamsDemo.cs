using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsDemo
{
    class StreamsDemo
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("input.txt");

            //while (!reader.EndOfStream)
            //{
            //    string line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
            //reader.Close();  // Closing the stream

            // ANOTHER WAY TO DO THE SAME THING

            using(StreamReader reader = new StreamReader("input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            } // AFTER THIS BRACKET THE STREAM CLOSES AUTOMATICALLY

            StreamWriter writer = new StreamWriter("output.txt");

            writer.WriteLine("Writing some message using StreamWriter class.");
            writer.WriteLine("Another line with StreamWriter class.");
            writer.Close();

            //using (StreamWriter writer = new StreamWriter("output.txt"))
            //{
            //    writer.WriteLine("Writing some message using StreamWriter class.");
            //    writer.WriteLine("Another line with StreamWriter class.");
            //}

            // IF WE WANT TO APPEND NEW TEXT TO ALREADY EXISTING

            StreamWriter appendWriter = new StreamWriter("output.txt", append: true);
            appendWriter.WriteLine("An append line with StreamWriter class.");
            appendWriter.Close();
        }
    }
}

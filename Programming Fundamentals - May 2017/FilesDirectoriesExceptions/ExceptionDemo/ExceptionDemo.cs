using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionDemo
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            var f = File.OpenText("Input.txt");

            try
            {
                while (true)
                {
                    var nextLine = f.ReadLine();
                    if (nextLine == null)
                        break;
                    //Console.WriteLine(int.Parse(nextLine)); // To cause Exception
                    Console.WriteLine(nextLine.ToUpper());
                }
            }
            finally
            {
                f.Close();
            }

            try
            {
                // Do some work that can cause an exception
            }
            catch (FileNotFoundException fileNotFoundEx)
            {
                // This block will be executed only if "file not found" exception occurs
            }
            finally
            {
                // This block will always execute
            }

            var dict = new Dictionary<string, double>()
            {
                { "Pesho", 3 },
                { "Gosho", 4 },
                { "Kiro", 3 }
            };

            var elements = dict.ToArray().OrderByDescending(e => e.Value).ToArray();

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i].Key + " -> " + elements[i].Value);
            }
        }
    }
}

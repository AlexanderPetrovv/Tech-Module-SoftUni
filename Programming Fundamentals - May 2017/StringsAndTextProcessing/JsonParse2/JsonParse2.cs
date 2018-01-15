using System;

namespace JsonParse2
{
    class JsonParse2
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            line = line.Substring(2, line.Length - 4);
            var tokens = line.Split(new[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] studentTokens = token.Split(new string[] { "name:\"", "\",age:", ",grades:" }, StringSplitOptions.RemoveEmptyEntries);
                string name = studentTokens[0];
                string age = studentTokens[1];
                string grades = studentTokens[2].Substring(1, studentTokens[2].Length - 2);

                if (grades == String.Empty)
                {
                    grades = "None";
                }
                Console.WriteLine("{0} : {1} -> {2} ", name, age, grades);
            }
        }
    }
}

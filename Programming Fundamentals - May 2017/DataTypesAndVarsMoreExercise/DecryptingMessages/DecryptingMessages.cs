using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You will receive a key (integer) and n characters afterward.
Add the key to each of the characters and append them to message.
At the end print the message, which you decrypted.
*/

namespace DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numOfChars = int.Parse(Console.ReadLine());

            string message = String.Empty;
            for (int currentChar = 0; currentChar < numOfChars; currentChar++)
            {
                char letter = char.Parse(Console.ReadLine());
                message += (char)(letter + key);
            }
            Console.WriteLine(message);
        }
    }
}

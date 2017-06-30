using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            var numberOfChars = int.Parse(Console.ReadLine());
            var message = String.Empty;

            for (int i = 0; i < numberOfChars; i++)
            {
                var digit = Console.ReadLine();
                var digitLength = digit.Length;
                var mainDigit = int.Parse(digit[0].ToString());
                var offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }
                var letterIndex = offset + digitLength - 1;

                if (mainDigit == 0)
                {
                    message += " ";
                }
                else
                {
                    message += (char)(97 + letterIndex);             // Adds letterIndex to ASCII code for lower 'a' which is 97
                }
            }
            Console.WriteLine(message);
        }
    }
}

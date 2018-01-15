using System;

namespace ValueOfAString
{
    class ValueOfAString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string lettersCase = Console.ReadLine();

            int sum = 0;

            if (lettersCase == "UPPERCASE")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (IsLetter(str[i]) && char.IsUpper(str[i]))
                    {
                        sum += str[i];
                    }
                }
            }
            else if (lettersCase == "LOWERCASE")
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (IsLetter(str[i]) && char.IsLower(str[i]))
                    {
                        sum += str[i];
                    }
                }
            }

            Console.WriteLine("The total sum is: {0}", sum);
        }

        static bool IsLetter(char ch)
        {
            return char.IsLetter(ch);
        }
    }
}

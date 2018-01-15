using System;

namespace DiamondProblem
{
    class DiamondProblem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int leftIndex = -1;
            int rightIndex = -1;
            bool hasDiamond = false;
            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1
                && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1)
            {
                string diamondData = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);

                int carats = CalcCarats(diamondData);

                Console.WriteLine($"Found {carats} carat diamond");

                hasDiamond = true;
            }

            if (!hasDiamond)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        static int CalcCarats(string diamondData)
        {
            int carats = 0;
            foreach (char symbol in diamondData)
            {
                if (char.IsDigit(symbol))
                {
                    carats += int.Parse(symbol.ToString());
                    //carats += symgol - '0';
                }
            }
            return carats;
        }
    }
}

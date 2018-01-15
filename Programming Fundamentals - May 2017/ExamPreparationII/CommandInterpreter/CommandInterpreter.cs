using System;
using System.Linq;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] cmdTokens = command.Split(' ');
                
                if (cmdTokens[0].Equals("reverse"))
                {
                    int startIndex = int.Parse(cmdTokens[2]);
                    int count = int.Parse(cmdTokens[4]);

                    if (IsValidInput(input, startIndex, count))
                    {
                        ReverseArrayPortion(input, startIndex, count);
                    }
                    else
                    {
                        InvalidInput();
                    }
                }
                else if (cmdTokens[0].Equals("sort"))
                {
                    int startIndex = int.Parse(cmdTokens[2]);
                    int count = int.Parse(cmdTokens[4]);

                    if (IsValidInput(input, startIndex, count))
                    {
                        SortArrayPortion(input, startIndex, count);
                    }
                    else
                    {
                        InvalidInput();
                    }
                }
                else if (cmdTokens[0].Equals("rollLeft"))
                {
                    int count = int.Parse(cmdTokens[1]);

                    if (count >= 0)
                    {
                        RollLeft(input, count);
                    }
                    else
                    {
                        InvalidInput();
                    }
                }
                else if (cmdTokens[0].Equals("rollRight"))
                {
                    int count = int.Parse(cmdTokens[1]);

                    if (count >= 0)
                    {
                        RollRight(input, count);
                    }
                    else
                    {
                        InvalidInput();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }

        static void InvalidInput()
        {
            Console.WriteLine("Invalid input parameters.");
        }

        static void RollRight(string[] input, int count)
        {
            int rolls = count % input.Length;

            for (int i = 0; i < rolls; i++)
            {
                string lastElement = input[input.Length - 1];
                for (int j = input.Length - 1; j > 0; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = lastElement;
            }
        }

        static void RollLeft(string[] input, int count)
        {
            int rolls = count % input.Length;
            
            for (int i = 0; i < rolls; i++)
            {
                string firstElement = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }               
                input[input.Length - 1] = firstElement;
            }           
        }

        static void SortArrayPortion(string[] input, int startIndex, int count)
        {
            var partToSort = input.Skip(startIndex).Take(count).ToArray();
            Array.Sort(partToSort);
            for (int i = 0; i < count; i++)
            {
                input[i + startIndex] = partToSort[i];
            }
        }

        static void ReverseArrayPortion(string[] input, int startIndex, int count)
        {
            int len = count / 2;
            for (int i = 0; i < len; i++)
            {
                var temp = input[startIndex];
                input[startIndex] = input[startIndex + count - i - 1];
                input[startIndex + count - i - 1] = temp;
                startIndex++;
                count--;
            }
        }

        static bool IsValidInput(string[] input, int startIndex, int count)
        {
            bool isInRange = startIndex < input.Length && startIndex >= 0;
            bool isValidCount = (startIndex + count) <= input.Length && count >= 0;

            return isInRange && isValidCount;
        }
    }
}

using System;
using System.Linq;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static int[] numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(' ');

                numbers = ManipulateArray(tokens);

                command = Console.ReadLine();
            }

            PrintFinalArray(numbers);
        }

        static int[] ManipulateArray(string[] tokens)
        {
            string cmd = tokens[0];
            string oddOrEven = String.Empty;
            int count = -1;

            switch (cmd)
            {
                case "exchange":
                    {
                        int index = int.Parse(tokens[1]);

                        if (index >= 0 && index < numbers.Length)
                        {
                            numbers = Exchange(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    }
                case "max":
                    {
                        oddOrEven = tokens[1];
                        bool isPresent = Exists(oddOrEven);

                        if (isPresent)
                        {
                            int maxIndex = GetIndexOfMaxElement(oddOrEven);
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;
                    }
                case "min":
                    {
                        oddOrEven = tokens[1];
                        bool isPresent = Exists(oddOrEven);

                        if (isPresent)
                        {
                            int minIndex = GetIndexOfMinElement(oddOrEven);
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }

                        break;
                    }
                case "first":
                    {
                        count = int.Parse(tokens[1]);
                        oddOrEven = tokens[2];

                        if (count >= 0 && count <= numbers.Length)
                        {
                            int[] firstElements = GetFirstElements(count, oddOrEven);
                            Console.WriteLine("[{0}]", string.Join(", ", firstElements));
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                        break;
                    }
                case "last":
                    {
                        count = int.Parse(tokens[1]);
                        oddOrEven = tokens[2];

                        if (count >= 0 && count <= numbers.Length)
                        {
                            int[] lastElements = GetLastElements(count, oddOrEven);
                            Console.WriteLine("[{0}]", string.Join(", ", lastElements));
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                        break;
                    }
            }

            return numbers;
        }

        static bool Exists(string oddOrEven)
        {
            if (oddOrEven == "odd")
            {
                return numbers.Any(x => x % 2 == 1);
            }
            else
            {
                return numbers.Any(x => x % 2 == 0);
            }
        }

        static int[] GetLastElements(int count, string oddOrEven)
        {
            if (oddOrEven == "odd")
            {
                int[] lastCountElements = numbers.Reverse().Where(x => x % 2 == 1).Take(count).Reverse().ToArray();
                return lastCountElements;
            }
            else
            {
                int[] lastCountElements = numbers.Reverse().Where(x => x % 2 == 0).Take(count).Reverse().ToArray();
                return lastCountElements;
            }
        }

        static int[] GetFirstElements(int count, string oddOrEven)
        {
            if (oddOrEven == "odd")
            {
                int[] firstCountElements = numbers.Where(x => x % 2 == 1).Take(count).ToArray();
                return firstCountElements;
            }
            else
            {
                int[] firstCountElements = numbers.Where(x => x % 2 == 0).Take(count).ToArray();
                return firstCountElements;
            }
        }

        static int GetIndexOfMinElement(string oddOrEven)
        {
            int minElement = int.MinValue;
            if (oddOrEven == "odd")
            {
                minElement = numbers.Where(x => x % 2 == 1).Min();
            }
            else
            {
                minElement = numbers.Where(x => x % 2 == 0).Min();
            }

            return Array.LastIndexOf(numbers, minElement);
        }

        static int GetIndexOfMaxElement(string oddOrEven)
        {
            int maxElement = int.MinValue;
            if (oddOrEven == "odd")
            {
                maxElement = numbers.Where(x => x % 2 == 1).Max();
            }
            else
            {
                maxElement = numbers.Where(x => x % 2 == 0).Max();
            }

            return Array.LastIndexOf(numbers, maxElement);
        }

        static int[] Exchange(int index)
        {
            int[] leftPart = numbers.Take(index + 1).ToArray();
            int[] rightPart = numbers.Skip(index + 1).ToArray();

            for (int i = 0; i < rightPart.Length; i++)
            {
                numbers[i] = rightPart[i];
            }

            for (int i = 0; i < leftPart.Length; i++)
            {
                numbers[numbers.Length - 1 + i - index] = leftPart[i];
            }

            return numbers;
        }

        static void PrintFinalArray(int[] numbers)
        {
            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }
    }
}

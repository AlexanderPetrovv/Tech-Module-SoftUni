using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string cmd = Console.ReadLine();

            while (cmd != "print")
            {
                List<string> command = cmd.Split(' ').ToList();
                switch (command[0])
                {
                    case "add":
                        AddElementAtSpecifiedIndex(command, numbers);
                        break;
                    case "addMany":
                        AddSetOfElementsAtSpecifiedPosition(command, numbers);                       
                        break;
                    case "contains":
                        PrintIndexOfFirstElementOccurrence(command, numbers);                      
                        break;
                    case "remove":
                        RemoveElementAtPosition(command, numbers);                 
                        break;
                    case "shift":
                        ShiftEveryElementToTheLeft(command, numbers);                       
                        break;
                    case "sumPairs":
                        SumElementsByPairs(command, numbers);                      
                        break;
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static void SumElementsByPairs(List<string> command, List<int> numbers)
        {
            //List<int> pairSum = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                //int currentElement = numbers[i];
                //int nextElement = 0;

                //if (i < numbers.Count - 1)
                //    nextElement = numbers[i + 1];

                //int elementsSum = currentElement + nextElement;
                //pairSum.Add(elementsSum);


                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
            //numbers = pairSum;       // NOTE: Only use if you won't need numbers as it wass before.
        }

        static void ShiftEveryElementToTheLeft(List<string> command, List<int> numbers)
        {
            int leftShiftCnt = int.Parse(command[1]) % numbers.Count;
            for (int i = 0; i < leftShiftCnt; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);

                // With arrays goes like this:
                //int firstNum = numbers[0];
                //for (int j = 0; j < numbers.Count - 1; j++)
                //{
                //    numbers[j] = numbers[j + 1];
                //}
                //numbers[numbers.Count - 1] = firstNum;
            }
        }

        static void RemoveElementAtPosition(List<string> command, List<int> numbers)
        {
            int removeIndex = int.Parse(command[1]);
            numbers.RemoveAt(removeIndex);
        }

        static void PrintIndexOfFirstElementOccurrence(List<string> command, List<int> numbers)
        {
            int containValue = int.Parse(command[1]);
            int index = numbers.IndexOf(containValue);
            Console.WriteLine(index);
        }

        static void AddSetOfElementsAtSpecifiedPosition(List<string> command, List<int> numbers)
        {
            int pos = int.Parse(command[1]);
            List<int> numsToInsert = new List<int>();
            for (int i = 2; i < command.Count; i++)
            {
                numsToInsert.Add(int.Parse(command[i]));
            }
            numbers.InsertRange(pos, numsToInsert);
        }

        static void AddElementAtSpecifiedIndex(List<string> command, List<int> numbers)
        {
            int index = int.Parse(command[1]);
            int value = int.Parse(command[2]);
            numbers.Insert(index, value);
        }
    }
}

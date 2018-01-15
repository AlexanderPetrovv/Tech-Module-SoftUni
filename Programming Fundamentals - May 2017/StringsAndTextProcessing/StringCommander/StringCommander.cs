using System;
using System.Text;

namespace StringCommander
{
    class StringCommander
    {
        static void Main(string[] args)
        {
            string strToManipulate = Console.ReadLine();

            var builder = new StringBuilder(strToManipulate);

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "Left":
                        int leftShifts = int.Parse(tokens[1]);
                        ShiftLeft(builder, leftShifts);
                        break;
                    case "Right":
                        int rightShifts = int.Parse(tokens[1]);
                        ShiftRight(builder, rightShifts);
                        break;
                    case "Insert":
                        int insertPos = int.Parse(tokens[1]);
                        string insertValue = tokens[2];
                        InsertElement(builder, insertPos, insertValue);
                        break;
                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        DeleteElement(builder, startIndex, endIndex);
                        break;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(builder.ToString());
        }

        static void ShiftLeft(StringBuilder builder, int leftShifts)
        {
            int shifts = leftShifts % builder.Length;

            for (int i = 0; i < shifts; i++)
            {
                builder.Append(builder[0]);
                builder.Remove(0, 1);
            }
        }

        static void ShiftRight(StringBuilder builder, int rightShifts)
        {
            int shifts = rightShifts % builder.Length;

            for (int i = 0; i < shifts; i++)
            {
                builder.Insert(0, builder[builder.Length - 1]);
                builder.Remove(builder.Length - 1, 1);
            }
        }

        static void InsertElement(StringBuilder builder, int insertPos, string insertValue)
        {
            builder.Insert(insertPos, insertValue);
        }

        static void DeleteElement(StringBuilder builder, int startIndex, int endIndex)
        {
            builder.Remove(startIndex, endIndex + 1 - startIndex);
        }
    }
}

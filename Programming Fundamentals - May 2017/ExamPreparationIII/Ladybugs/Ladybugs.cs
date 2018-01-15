using System;
using System.Linq;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = InitializeField(fieldSize, initialIndices);

            string cmd = Console.ReadLine();

            while (!cmd.Equals("end"))
            {
                string[] tokens = cmd.Split(' ');
                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if ((ladybugIndex >= 0 && ladybugIndex < field.Length) && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;

                    direction = GetDirection(direction, flyLength);
                    flyLength = Math.Abs(flyLength);

                    int landIndex = 0;

                    if (direction == "right")
                    {
                        landIndex = ladybugIndex + flyLength;
                        while (landIndex < field.Length)
                        {
                            if (field[landIndex] == 0)
                            {
                                field[landIndex] = 1;
                                break;
                            }
                            landIndex += flyLength;
                        }
                    }
                    else if (direction == "left")
                    {
                        landIndex = ladybugIndex - flyLength;
                        while (landIndex >= 0)
                        {
                            if (field[landIndex] == 0)
                            {
                                field[landIndex] = 1;
                                break;
                            }
                            landIndex -= flyLength;
                        }
                    }
                }

                cmd = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static string GetDirection(string direction, int flyLength)
        {
            if (flyLength < 0)
            {
                if (direction == "right")
                {
                    return "left";
                }
                else if (direction == "left")
                {
                    return "right";
                }
            }
            return direction;
        }

        static int[] InitializeField(int fieldSize, int[] initialIndices)
        {
            int[] field = new int[fieldSize];
            foreach (int index in initialIndices)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }
            return field;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You have the task to write a simulator of a boat race. You will receive two characters, which will represent the two boats.
After that you will receive n random strings.
Each string on an odd line represents the speed of the first boat and on an even line – the speed of the second boat.
The boat moves with the count of the tiles, equal to the length of the given string. The first boat, which reaches 50 tiles is the winner.
Our boats can be upgradable, which means when we receive the string “UPGRADE” we add 3 to the ASCII codes of
both of the boats characters and after that, we use those characters to represent the boats.
If you receive “UPGRADE”, you should not move the boats.
If one of the boats reaches 50 moves – print the character of the winner and stop taking any input.
If neither of the boats reach 50 moves – print the boat, which reached the most moves. At the end, the boats will not have equal moves.
*/

namespace BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int numOfStrings = int.Parse(Console.ReadLine());

            int firstBoatTiles = 0;
            int secondBoatTiles = 0;
            for (int str = 1; str <= numOfStrings; str++)
            {
                string moveString = Console.ReadLine();
                if (moveString == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }

                if (str % 2 == 1)
                {
                    firstBoatTiles += moveString.Length;
                }
                else
                {
                    secondBoatTiles += moveString.Length;
                }

                if (firstBoatTiles >= 50 || secondBoatTiles >= 50)
                {
                    break;
                }
            }

            Console.WriteLine(firstBoatTiles > secondBoatTiles ? firstBoat : secondBoat);
        }
    }
}

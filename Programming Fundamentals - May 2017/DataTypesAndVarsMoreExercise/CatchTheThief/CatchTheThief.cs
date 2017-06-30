using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
In the future, a very dangerous thief has escaped.
Your mission is to catch him, but the only thing you know is the numeral type, which is his id.
On the first line, you will receive the numeral type of thief’s id.
On the second line, you will receive n – the number of ids you will receive.
The person who has an id closest to the maximum value of the given numeral type without overflowing it is the thief’s id.
*/

namespace CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string thiefNumeralType = Console.ReadLine();
            int countOfIds = int.Parse(Console.ReadLine());

            long maxPossibleId = 0;
            switch (thiefNumeralType)
            {
                case "sbyte":
                    maxPossibleId = sbyte.MaxValue;
                    break;
                case "int":
                    maxPossibleId = int.MaxValue;
                    break;
                case "long":
                    maxPossibleId = long.MaxValue;
                    break;
            }

            long maxThiefId = long.MinValue;
            for (int i = 0; i < countOfIds; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (id > maxThiefId && id <= maxPossibleId)
                {
                    maxThiefId = id;
                }
            }

            Console.WriteLine(maxThiefId);
        }
    }
}

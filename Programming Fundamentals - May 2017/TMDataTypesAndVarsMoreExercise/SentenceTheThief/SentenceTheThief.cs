using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
In the last task, you caught the thief, but in the future, everyone is multitasking and you need to calculate his sentence as well.
His sentence equals to the times his id overflows the numerical type sbyte.
Round the years to the nearest larger integer value (5.01 -> 6).
Example: If the thief’s id is 5251, that means the sentence will equal: 5251 / 127 = 41.35 years.
Rounded to the next integer value, the final sentence would be 42 years.
Notice that the id might be negative and can overflow the negative boundary of sbyte. The id will never be 0.
*/

namespace SentenceTheThief
{
    class SentenceTheThief
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

            long sentence = 0;
            if (maxThiefId > 0)
            {
                sentence = (long)Math.Ceiling((double)maxThiefId / sbyte.MaxValue);
            }
            else if (maxThiefId < 0)
            {
                sentence = (long)Math.Ceiling((double)maxThiefId / sbyte.MinValue);
            }

            if (sentence < 2)
            {
                Console.WriteLine($"Prisoner with id {maxThiefId} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {maxThiefId} is sentenced to {sentence} years");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] inputToCharArr = input.ToCharArray();

            List<int> numbersList = inputToCharArr.Where(x => char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();
            List<char> nonNumList = inputToCharArr.Where(x => !char.IsDigit(x)).ToList();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            int total = 0;
            string result = String.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];
                result += new string(nonNumList.Skip(total).Take(take).ToArray());
                total += skip + take;
            }

            Console.WriteLine(result);
        }
    }
}

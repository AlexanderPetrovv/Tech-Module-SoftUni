using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                List<int> currentList = Console.ReadLine().Split().Select(int.Parse).ToList();
                ManipulatePrimalList(primalList, currentList);               
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }

        static void ManipulatePrimalList(List<int> primalList, List<int> currentList)
        {
            for (int j = 0; j < currentList.Count; j++)
            {
                if (primalList.Contains(currentList[j]))
                {
                    primalList.RemoveAll(x => x == currentList[j]);
                }
                else
                {
                    primalList.Add(currentList[j]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            var cnt = 0;

            while (true)
            {
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    cnt++;
                }
                catch (Exception)
                {
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}

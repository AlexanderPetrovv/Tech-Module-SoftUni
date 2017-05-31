using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            var imageWidth = int.Parse(Console.ReadLine());
            var imageHeight = int.Parse(Console.ReadLine());

            var megapixels = (imageWidth * imageHeight) / 1000000.0;
            Console.WriteLine($"{imageWidth}x{imageHeight} => {Math.Round(megapixels, 1)}MP");
        }
    }
}

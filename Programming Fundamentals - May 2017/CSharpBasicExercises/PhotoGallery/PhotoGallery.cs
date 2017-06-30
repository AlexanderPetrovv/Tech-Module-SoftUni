using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoSizeBytes = double.Parse(Console.ReadLine());
            var photoWidth = int.Parse(Console.ReadLine());
            var photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");

            var suffix = "";
            if (photoSizeBytes < 1000)
            {
                suffix = "B";
            }
            else if (photoSizeBytes < 1000000)
            {
                suffix = "KB";
                photoSizeBytes /= 1000.0;
            }
            else
            {
                suffix = "MB";
                photoSizeBytes /= 1000000.0;
            }

            Console.WriteLine($"Size: {photoSizeBytes}{suffix}");

            var orientation = "";
            if (photoWidth < photoHeight)
            {
                orientation = "portrait";
            }
            else if (photoWidth > photoHeight)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} ({orientation})");
        }
    }
}

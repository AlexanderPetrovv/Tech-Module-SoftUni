using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTimeInSec = int.Parse(Console.ReadLine());     // Time in seconds for every picture to be filtered
            int rdyPicsPercent = int.Parse(Console.ReadLine());      // Filter factor - percentage of pictures ready to be uploaded
            int pictureUploadTime = int.Parse(Console.ReadLine());   // Amount of time needed for every filtered picture to be uploaded

            long filterTime = (long)totalPictures * filterTimeInSec;
            long filteredPics = (long)Math.Ceiling(rdyPicsPercent * (totalPictures / 100.0));
            long totalUploadTime = filteredPics * pictureUploadTime;
            long totalTimeSecs = filterTime + totalUploadTime;
            var totalTimeSpan = TimeSpan.FromSeconds(totalTimeSecs);

            Console.WriteLine($"{totalTimeSpan:d\\:hh\\:mm\\:ss}");
            // or Console.WriteLine(totalTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}

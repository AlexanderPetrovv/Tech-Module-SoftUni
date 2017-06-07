using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.
Each three lines will hold information for a single keg.
First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
Calculate the volume using the following formula: π * r^2 * h.
At the end, print the model of the biggest keg.
*/
namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int kegCnt = int.Parse(Console.ReadLine());

            double maxKegVolume = 0.0;
            string largestKegModel = String.Empty;
            for (int currentKeg = 0; currentKeg < kegCnt; currentKeg++)
            {
                string kegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * kegRadius * kegRadius * kegHeight;
                if (currentKegVolume > maxKegVolume)
                {
                    maxKegVolume = currentKegVolume;
                    largestKegModel = kegModel;
                }
            }

            Console.WriteLine(largestKegModel);
        }
    }
}

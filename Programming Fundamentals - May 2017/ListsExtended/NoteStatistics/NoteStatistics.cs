using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {        
            var freqChart = new Dictionary<string, double>();
            freqChart["C"] = 261.63;
            freqChart["C#"] = 277.18;
            freqChart["D"] = 293.66;
            freqChart["D#"] = 311.13;
            freqChart["E"] = 329.63;
            freqChart["F"] = 349.23;
            freqChart["F#"] = 369.99;
            freqChart["G"] = 392.00;
            freqChart["G#"] = 415.30;
            freqChart["A"] = 440.00;
            freqChart["A#"] = 466.16;
            freqChart["B"] = 493.88;

            List<string> possibleNotes = freqChart.Keys.ToList();
            List<double> possibleFreqs = freqChart.Values.ToList();

            List<double> frequences = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<string> notes = new List<string>();
            List<string> naturalNotes = new List<string>();
            List<string> sharpNotes = new List<string>();
            double naturalsSum = 0;
            double sharpsSum = 0;

            for (int i = 0; i < frequences.Count; i++)
            {
                double currentFreq = frequences[i];
                int index = possibleFreqs.IndexOf(currentFreq);

                notes.Add(possibleNotes[index]);
                if (notes[i].Contains("#"))
                {
                    sharpNotes.Add(possibleNotes[index]);
                    sharpsSum += possibleFreqs[index];
                }
                else
                {
                    naturalNotes.Add(possibleNotes[index]);
                    naturalsSum += possibleFreqs[index];
                }
            }

            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: " + string.Join(", ", sharpNotes));
            Console.WriteLine("Naturals sum: {0:0.##}", naturalsSum);
            Console.WriteLine("Sharps sum: {0:0.##}", sharpsSum);

            foreach (var item in frequences)
            {
                Console.Beep((int)item, 400);
            }
        }
    }
}

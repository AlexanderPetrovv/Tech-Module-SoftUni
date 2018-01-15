using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");

            List<string> mergedFiles = new List<string>();
            var maxLength = Math.Max(firstFile.Length, secondFile.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < firstFile.Length)
                {
                    mergedFiles.Add(firstFile[i]);
                }

                if (i < secondFile.Length)
                {
                    mergedFiles.Add(secondFile[i]);
                }
            }

            File.WriteAllLines("Result.txt", mergedFiles);
        }
    }
}

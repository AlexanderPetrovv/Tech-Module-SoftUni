using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterExtensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            string targetExtension = Console.ReadLine();

            string[] files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                if (extension == "." + targetExtension)
                {
                    Console.WriteLine(fileInfo.Name);
                }
            }
        }
    }
}

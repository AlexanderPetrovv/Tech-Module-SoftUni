using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class File
    {
        public string Root { get; set; }
        
        public string FileName { get; set; }

        public long FileSize { get; set; }

        public File(string root, string fileName, long fileSize)
        {
            this.Root = root;
            this.FileName = fileName;
            this.FileSize = fileSize;
        }

        public override bool Equals(object obj)
        {
            if (obj is File)
            {
                File other = (File)obj;

                return this.FileName == other.FileName;
            }
            return false;
        }
    }

    class Files
    {
        static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());

            var files = new Dictionary<string, List<File>>();

            for (int i = 0; i < numberOfFiles; i++)
            {
                string[] currentFileTokens = Console.ReadLine().Split(new[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                string root = currentFileTokens.First();
                string fileName = currentFileTokens.Reverse().Skip(1).Take(1).ToArray()[0];
                long fileSize = long.Parse(currentFileTokens.Last());

                File file = new File(root, fileName, fileSize);

                if (!files.ContainsKey(root))
                {
                    files[root] = new List<File>();
                }

                if (!files[root].Contains(file))
                {
                    files[root].Add(file);
                }
                else
                {
                    int index = files[root].IndexOf(file);
                    files[root][index] = file;
                }
                
            }

            string[] queryTokens = Console.ReadLine().Split(' ');
            string queryExtension = queryTokens[0];
            string queryRoot = queryTokens[2];
            
            if (files.ContainsKey(queryRoot))
            {
                if (files[queryRoot].Where(f => f.FileName.Split('.').Last() == queryExtension).Count() > 0)
                {
                    foreach (File file in files[queryRoot]
                        .Where(f => f.FileName.Split('.').Last() == queryExtension)
                        .OrderByDescending(f => f.FileSize)
                        .ThenBy(f => f.FileName))
                    {
                        Console.WriteLine($"{file.FileName} - {file.FileSize} KB");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

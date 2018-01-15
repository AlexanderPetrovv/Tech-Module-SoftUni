using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Directory
{
    class ReDirectory
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("input");

            foreach (var file in files)
            {
                string fileExtension = file.Substring(file.LastIndexOf(".") + 1);

                if (!Directory.Exists("./output/" + fileExtension + "s"))
                {
                    Directory.CreateDirectory("./output/" + fileExtension + "s");
                }

                string fileName = file.Substring(file.LastIndexOf("\\"));
                Directory.Move(file, "./output/" + fileExtension + "s" + fileName);
            }
        }
    }
}

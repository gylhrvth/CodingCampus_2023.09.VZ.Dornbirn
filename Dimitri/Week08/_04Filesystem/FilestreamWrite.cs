using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class FilestreamWrite
    {
        public static void Main()
        {
            string path = @"/Users/dimit/Source/Repos/CodingCampus_2023.09.VZ.Dornbirn/Dimitri/Week08/NewFile.cs";

            WriteFile(path);


        }

        public static void WriteFile(string path)
        {
            using (FileStream fs = File.OpenWrite(path))
            {
                byte[] b = new byte[1024];
                string test = "test";
                UTF8Encoding temp = new UTF8Encoding(true);
                b = temp.GetBytes(test);
                fs.Write(b, 0, b.Length);
            }
        }
    }
}

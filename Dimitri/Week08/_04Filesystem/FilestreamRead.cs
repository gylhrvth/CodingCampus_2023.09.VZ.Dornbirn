using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class FilestreamRead
    {
        public static void Main()
        {
            string path = @"/Users/dimit/Source/Repos/CodingCampus_2023.09.VZ.Dornbirn/Dimitri/Week01/HelloWorld.cs";

            ReadFile(path);


        }

        public static void ReadFile(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                int readLen;
                while((readLen = fs.Read(b,0,b.Length)) > 0)
                {
                    Console.WriteLine(temp.GetString(b, 0, readLen));
                }
            }
        }
    }
}

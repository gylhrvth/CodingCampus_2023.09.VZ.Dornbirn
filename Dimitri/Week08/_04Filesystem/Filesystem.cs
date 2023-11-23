using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class Filesystem
    {
        public static void Main()
        {
            PrintDCVDirStruct();
        }

        public static void PrintDCVDirStruct()
        {
            string currentDir = Directory.GetCurrentDirectory();

            string[] subDirs = Directory.GetDirectories(currentDir);

            DirectoryInfo directoryInfo = new DirectoryInfo(currentDir);



            Console.WriteLine(currentDir);

            Console.WriteLine(directoryInfo.Name);

            foreach(string subDir in subDirs) {
                Console.WriteLine(subDir);
            }


        }
    }
}

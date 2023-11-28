using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem
{
    public class Filesystemtraversal
    {
        public static void Start()
        {
            PrintFileTraversal("C:\\Users\\BAU21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon", "---");


        }

        public static void PrintFileTraversal(string path, string prefix)
        {
            //DirectoryInfo pathDirectoryInfo = new DirectoryInfo(path);
            //FileInfo pathfileInfo = new FileInfo(path);
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo pathfileInfo = new FileInfo(file);
                Console.WriteLine(prefix + pathfileInfo.Name);

            }

            foreach (string dir in directories)
            {
                DirectoryInfo pathDirectoryInfo = new DirectoryInfo(dir);
                Console.WriteLine(prefix + pathDirectoryInfo.Name);
                PrintFileTraversal(dir, prefix + "+++");
            }
        }

    }
}

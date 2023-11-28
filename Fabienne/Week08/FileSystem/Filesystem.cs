using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week08.FileSystem
{
    internal class Filesystem
    {
        public static void Start()
        {
            string direct = "C:\\Users\\Fabienne\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn";
            GetDirectory(direct);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Size of all files: " + Calculations(direct) + " bytes");
        }

        public static void GetDirectory(string direct)
        {
            string[] directories = Directory.GetDirectories(direct);
            string[] files = Directory.GetFiles(direct);

            Console.WriteLine("--------------Directories--------------");
            foreach (string direc in directories)
            {
                DirectoryInfo dir = new DirectoryInfo(direc);
                Console.WriteLine(dir.Name);
            }
            Console.WriteLine("-----------------Files-----------------");
            foreach (string fil in files)
            {
                FileInfo file = new FileInfo(fil);
                Console.WriteLine(file.Name);
            }
        }
        public static long Calculations(string direct)
        {
            long calc = 0;
            string[] files = Directory.GetFiles(direct);
            foreach (string fil in files)
            {
                FileInfo file = new FileInfo(fil);
                calc += file.Length;
            }
            return calc;
        }     
        public static void FilesyTraversal()
        {
             
        }
    }
}

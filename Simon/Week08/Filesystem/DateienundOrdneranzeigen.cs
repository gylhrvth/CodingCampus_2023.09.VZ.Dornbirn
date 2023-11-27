using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem
{
    public class DateienundOrdneranzeigen
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();
        private static DirectoryInfo currentDirecotryInfo = new DirectoryInfo(currentDirectory);
        private static string directorydepth = currentDirecotryInfo.Parent.Parent.Parent.Parent.FullName;

        public static void Start()
        {
            PrintFiles();
            Console.WriteLine("\nCalcFliesize:");
            CalcFilesize();

        }

        public static void PrintFiles()
        {
            string[] directoryChildrenlist = Directory.GetDirectories(directorydepth);
            string[] filechildren = Directory.GetFiles(directorydepth);

            Console.WriteLine("Dateien:");
            foreach (string file in filechildren)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine(fileInfo.Name + " Dateigröße: " + fileInfo.Length +" bites");

            }
            Console.WriteLine("Ordner:");
            foreach (string dir in directoryChildrenlist)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                Console.WriteLine(dirInfo.Name);
            }
        }

        public static void CalcFilesize()
        {
            string[] filechildren = Directory.GetFiles(directorydepth);
            long filesize = 0;
            foreach(string file in filechildren)
            {
                FileInfo fileInfo = new FileInfo(file);
                filesize += fileInfo.Length;
            }
            Console.WriteLine(filesize);
        }



    }
}

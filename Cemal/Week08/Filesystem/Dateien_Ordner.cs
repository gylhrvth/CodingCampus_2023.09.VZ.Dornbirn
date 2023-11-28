using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week08.Filesystem
{
    public class Dateien_Ordner
    {
        public static void Start()
        {
            string currentdirectory = Directory.GetCurrentDirectory();


            //Files Ausgabe
            Console.WriteLine("Files:");

            string[] children = Directory.GetFiles(currentdirectory);

            foreach (var child in children)
            {
                FileInfo fileinfo = new FileInfo(child);
                Console.WriteLine(fileinfo.Name + "\t" + ConverttoMB(fileinfo.Length) + " mb");
            }
            Console.WriteLine();


            //Directories Ausgabe
            Console.WriteLine("Directories:");

            var currentdirectoryInfo = new DirectoryInfo(currentdirectory);

            string projektDirectory = currentdirectoryInfo.Parent.Parent.Parent.Parent.FullName;
            Console.WriteLine("Projekt directory: " + projektDirectory);

            string[] directories = Directory.GetDirectories(projektDirectory);

            foreach (var direcs in directories)
            {
                FileInfo fileInfo = new FileInfo(direcs);
                Console.WriteLine(fileInfo.Name);
            }
            Console.WriteLine();

            //Coding Campus Files(oberste Ebene)
            Console.WriteLine("First Layer Files: ");

            string[] child1 = Directory.GetFiles(@"C:\Windows\");

            long result = 0;

            foreach (var direcs in child1)
            {
                FileInfo fileInfo = new FileInfo(direcs);
                Console.WriteLine(fileInfo.Name + "\t" + ConverttoMB(fileInfo.Length) + " mb");
                result += fileInfo.Length;
            }
            Console.WriteLine();
            Console.WriteLine("Files in CodingCampus total MB: " + ConverttoMB(result));



            ////// Traversal/////



            Console.WriteLine();
            Console.WriteLine("-------------------Filesystem traversal-------------------");

            var currentdirectoryInfoPrint = new DirectoryInfo(currentdirectory);
            string startdirectory = currentdirectoryInfoPrint.Parent.Parent.Parent.Parent.FullName;

            PrintFileTree(startdirectory, "-----");
        }




        public static void PrintFileTree(string startdirectory, string praefix)
        {

            string[] directories = Directory.GetDirectories(startdirectory);
            foreach (string subfolder in directories)
            {
                Console.WriteLine(praefix + " Ordner: " + new DirectoryInfo(subfolder).Name);
            }


            string[] files = Directory.GetFiles(startdirectory);
            foreach (string subfiles in files)
            {
                Console.WriteLine(praefix + " Files: " + new DirectoryInfo(subfiles).Name);
                PrintFileTree(subfiles, praefix + "-----");
            }
        }

















        public static double ConverttoMB(long sizeinByte)
        {
            double result = sizeinByte / 1024.0 / 1024;
            return Math.Round(result, 2);
        }


    }
}

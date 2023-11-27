using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week08.Filesystem
{
    public class DateienundOrdner
    {

        public static void Start()
        {
            /*
            //ich rufe meinen aktuellen ordner auf / GetCurrentDirectory() ist eine Methode die schon in C# vorhanden ist
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Data:" + currentDirectory);

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            Console.WriteLine("new" + currentDirectoryInfo);


            //mit dem befehl dateiname.Parent kann ich jeweils immer 1 ebene rauf springen
            string prjectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.Parent.Parent.FullName;
            Console.WriteLine("RootDirectory:" + prjectRootDirectory);


            //TEST
            Console.WriteLine("\n\n\n");*/



            Console.WriteLine("TEST");
            string directoryPath = Directory.GetCurrentDirectory();
            Console.WriteLine(directoryPath);
            ListFilesRecursively(new DirectoryInfo(directoryPath));


            string[] children = Directory.GetFiles(directoryPath);
            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(fileInfo.Name + " " + Math.Round(ConvertToMByte(fileInfo.Length), 2) + "mb");
            }

            //PrintFileCountAndSum(directoryPath);
        }

        static void ListFilesRecursively(DirectoryInfo root)
        {
            Console.WriteLine($"Directory: {root.Name}");

            //Anzeigen der Dateien im aktuellen Verzeichnis
            FileInfo[] files = root.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"|------ {file.Name}");
            }

            DirectoryInfo[] subDirectories = root.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                ListFilesRecursively(subDirectory);
            }

        }

        public static float ConvertToMByte(long sizeinByte)
        {
            return sizeinByte / 1024.0f / 1024;
        }

        //static void PrintFileCountAndSum(string directoryPath)
        //{
        //    DirectoryInfo directory = new DirectoryInfo(directoryPath);

        //    int numFiles = 0;
        //    long fileSumLength = 0;

        //    FileInfo[] fileList = directory.GetFiles();
        //    foreach (FileInfo file in fileList)
        //    {

        //        numFiles++;
        //        fileSumLength += file.Length;

        //    }

        //    Console.WriteLine($"Anzahl der Dateien im Verzeichnis: {numFiles}");
        //    Console.WriteLine($"Summe der Größe der Dateien: {fileSumLength} bytes");
        //}
    }
}



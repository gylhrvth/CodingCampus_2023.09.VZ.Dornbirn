using System;
using System.IO;

namespace Mohammed.Week08.FileSystem
{
    public class DateienUndOrdner
    {
        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);


            DirectoryInfo directoryInfo = new DirectoryInfo(currentDirectory);
            directoryInfo = directoryInfo.Parent.Parent.Parent.Parent;


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(">>>" + directoryInfo);


            Console.ForegroundColor = ConsoleColor.Red;
            foreach (DirectoryInfo childDirectory in directoryInfo.GetDirectories())
            {
                Console.WriteLine("Ordner: {0}", childDirectory.Name);
            }
 
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("     Datei: {0}, Größe: {1} ", fileInfo.Name, fileInfo.Length);
            }


            Console.WriteLine("========Rekursiv=======");

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);

            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.FullName;
            DirectoryInfo rootFolder = currentDirectoryInfo.Parent.Parent.Parent;// Da habe ich geschrieben, damit ich ein DirectoryInfo

            Console.WriteLine("Rekursiv directory: " + projectRootDirectory);

            string[] directoryChildren = Directory.GetDirectories(projectRootDirectory);


            PrintDirectory(rootFolder);

         
        }


        public static void PrintDirectory(DirectoryInfo directoryInfo)
        {
            

            foreach (var directory in directoryInfo.GetDirectories())
            {

                Console.WriteLine("     ├──" + directory.Name);

                PrintDirectory(directory);
            }

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                Console.WriteLine("├──" + file.Name);
                
            }
        }

        




    }
}


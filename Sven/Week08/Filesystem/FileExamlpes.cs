using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week08.Filesystem
{
    internal class FileExamlpes
    {
        public static void Start()
        {
            Console.WriteLine("Dateien und Ordner:");
            string currentDirectory = Directory.GetCurrentDirectory();
            var directoryInfo = new DirectoryInfo(currentDirectory);

            Console.WriteLine($"Contents of {directoryInfo.FullName}");


            string projectRootDirectory = directoryInfo.Parent.Parent.Parent.Parent.FullName;

            Console.WriteLine("ProjectRootDirectory" + projectRootDirectory);

            long result = 0;
            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine("File: " + file.Name + "Filesize: " + ConvertToMB(file.Length) + " MB");
                result += file.Length;
            }
            Console.WriteLine("Result: " + ConvertToMB(result) + "MB");

            string path = @"C:\Users\juens\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Sven";
            FileSystemTraversal(path, " ");
        }
        public static double ConvertToMB(long sizeInfo)
        {
            double f = sizeInfo / 1024.0 / 1024;
            return Math.Round(f, 2);


        }
        public static void FileSystemTraversal(string path, string prefix)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                if (file == files.Last())
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(file)}");

                }
                else
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(file)}");

                }

            }
            foreach (string directory in directories)
            {
                if (directory == directories.Last())
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(directory)}");
                    FileSystemTraversal(directory, $"{prefix}    ");

                }
                else
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(directory)}");
                    FileSystemTraversal(directory, $"{prefix}    ");



                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Kerem.Week08.Files
{
    internal class FilesData
    {
        public FilesData()
        {
        }

        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("---CurrentDirectory---");
            Console.WriteLine(currentDirectory);
            Console.WriteLine("---Files---");

            string[] files = Directory.GetFiles(currentDirectory);
            long result = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine(fileInfo.Name + " " + (ConvertToMByte(fileInfo.Length) + " MB"));
                result += fileInfo.Length;

            }
            Console.WriteLine("Result: "+ ConvertToMByte(result)+" MB") ;
            Console.WriteLine("---Directories---");

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);

            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.FullName;

            Console.WriteLine("Project root directory: " + projectRootDirectory);

            Console.WriteLine("-----------FileSystemTraversal----------");
            string path = @"C:\Users\DCV\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Kerem";
            FileSystemTraversal(path, " ");
            

        }
        public static double ConvertToMByte(long sizeInfo)
        {
            double f = sizeInfo / 1024.0 / 1024;
            return Math.Round(f, 2);
            
        }
       
        public static void FileSystemTraversal(string path,string prefix)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                if (file == files.Last())
                    Console.WriteLine($"{prefix}└── {Path.GetFileName(file)}");
                else
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(file)}");
            }

            foreach (string directory in directories)
            {
                if (directory == directories.Last())
                {
                    Console.WriteLine($"{prefix}└── {Path.GetFileName(directory)}");
                    FileSystemTraversal(directory, $"{prefix}    ");
                }
                else
                {
                    Console.WriteLine($"{prefix}├── {Path.GetFileName(directory)}");
                    FileSystemTraversal(directory, $"{prefix}|   ");
                }
            }


        }

    }
}

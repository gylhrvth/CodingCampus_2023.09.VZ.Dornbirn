using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace David.Week08.Filesystem
{
    public class Files_DateinUOrdner
    {
        public Files_DateinUOrdner()
        {
        }

        public static void Start()
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine(path);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo = directoryInfo.Parent.Parent.Parent;
            Console.WriteLine(directoryInfo.FullName);

            PrintDirectory(directoryInfo, "");
        }

        public static void PrintDirectory(DirectoryInfo directoryInfo, string indent)
        {
            foreach (DirectoryInfo d in directoryInfo.GetDirectories())
            {
                Console.WriteLine(indent + "d: " + d.Name);
                PrintDirectory(d, indent + " - ");
            }

            long size = 0;

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Console.WriteLine(indent + "f: " + fileInfo.Name + " " + Math.Round(ConvertToKByte(fileInfo.Length), 2) + "KB");
                size += fileInfo.Length;
            }

            Console.WriteLine("Total size: " + Math.Round(ConvertToKByte(size), 2) + "KB");
            Console.WriteLine("-----");
        }

        public static float ConvertToKByte(long sizeInByte)
        {
            return sizeInByte / 1024f;
        }

        public static void FileTraversalUse(int depth, string path)
        {
            path = "/Users/davidisele/Projects/CodingCampus_2023.09.VZ.Dornbirn/David";



        }


    }

}



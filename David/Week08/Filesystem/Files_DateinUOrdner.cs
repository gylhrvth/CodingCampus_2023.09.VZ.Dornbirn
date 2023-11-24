using System;
using System.IO;
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
                PrintDirectory(d, indent + "  ");
            }

            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                //SumOfAllFileSize(fileInfo.Length);
                Console.WriteLine(indent + "f: " + fileInfo.Name + " " + Math.Round(ConvertToKByte(fileInfo.Length), 2) + "KB");
            }
        }

        public static float ConvertToKByte(long sizeInByte)
        {
            return sizeInByte / 1024f;
        }

        public static float SumOfAllFileSize(long value)
        {
            long sum = 0;
            return sum + value;
        }
    }

}



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week08.Files
{
    public class File
    {
        public static void Start()
        {
            string dicretory = Directory.GetCurrentDirectory();
            //string[] Files = Directory.GetFiles(dicretory); //bekommt die file

            //Console.WriteLine("Creation Date: " + Directory.GetCreationTime(dicretory)); //erstellung datum von dicretory
            DirectoryInfo directoryInfo = new DirectoryInfo(dicretory); //aktuellen Ordner zur obersten Ebene zu navigieren.

            string orderName = directoryInfo.Parent.Parent.Parent.FullName;

            Filesystemtraversal(orderName);

            //PrintFolder(orderName);

            //Filesystemtraversal(orderName);

            //PrintFilesSizes(Files);
            //CalculateFileSize(orderName);

        }

        public static void PrintFilesSizes(string[] Files)
        {
            foreach (string file in Files)
            {
                Console.WriteLine("Size: " + file.Length);
            }
        }

        public static void PrintFolder(string folder)
        {
            Console.WriteLine("Currentfolder: " + folder);
        }

        public static double CalculateFileSize(string folder)
        {
            DirectoryInfo fileInfo = new DirectoryInfo(folder);


            FileInfo[] Files = fileInfo.GetFiles();

            double size = 0;

            foreach (FileInfo file in Files)
            {
                size += file.Length;
            }

            Console.WriteLine("Size: {0} Mbbytes", ConvertToMbyte(size));

            return size;

        }

        public static double ConvertToMbyte(double bytes)
        {
            return bytes / 1024 / 1024;
        }

        public static void Filesystemtraversal(string path)
        {
            Console.WriteLine("Test");
            string dicretory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(dicretory);
            Console.WriteLine(directoryInfo);

            string[] files = Directory.GetFiles(dicretory);
            string[] dir = Directory.GetDirectories(dicretory);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine(" " + fileInfo.Name);

            }

            foreach (string folder in dir)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                Console.WriteLine(dirInfo.Name);

                Filesystemtraversal("-----" + folder);

            }

        }


    }
}

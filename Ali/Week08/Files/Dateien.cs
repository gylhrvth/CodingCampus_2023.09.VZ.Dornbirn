using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week08.Files
{
    public class Dateien
    {

        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            Console.WriteLine(currentDirectory);

            Console.WriteLine("--------------------------------------");




            string[] children = Directory.GetFiles(currentDirectory);

            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(fileInfo.Name + " " + ((fileInfo.Length)) + "byte");

                Console.WriteLine("------------------------------------------------");
            }
            Console.WriteLine(CountFileLength(currentDirectory) + (" byte is the Sum of the Folder"));
        }
        public static long CountFileLength(string filepath)
        {
            long fileSum = 0;

            {
                DirectoryInfo directoryInfo = new DirectoryInfo(filepath);

                if (directoryInfo.Exists)
                {
                    FileInfo[] files = directoryInfo.GetFiles();

                    foreach (FileInfo file in files)
                    {
                        fileSum += file.Length;

                    }
                }
                return fileSum;



            }







        }
    }
}

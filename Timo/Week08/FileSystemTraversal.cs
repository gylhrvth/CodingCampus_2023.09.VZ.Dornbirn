using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08
{
    public class FileSystemTraversal
    {
        public static void Start()
        {
            string path = "C:\\Users\\aau27722\\source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Timo";
            string prefix = "";
            Filesystem(path, prefix);
        }

        public static void Filesystem(string path, string prefix) 
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                if (directory == directories.Last())
                {
                    Console.WriteLine("" + prefix + "└──" + directoryInfo.Name);

                    Filesystem(directoryInfo.FullName, prefix + "│  ");
                }
                else
                {
                    Console.WriteLine("" + prefix + "├──" + directoryInfo.Name);

                    Filesystem(directoryInfo.FullName, prefix + "│  ");
                }
            }

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (file == files.Last())
                {
                    Console.WriteLine("" + prefix + "└──" + fileInfo.Name);
                }
                else
                {
                    Console.WriteLine("" + prefix + "├──" + fileInfo.Name);
                }
            }
            
        }
    }
}

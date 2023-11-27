using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    public class RecursiveDirectory
    {
        public RecursiveDirectory()
        {
        }

        public static void Start()
        {
            string name = Directory.GetCurrentDirectory();

            Console.WriteLine(name);

            DirectoryInfo rootFolder = new DirectoryInfo(name).Parent.Parent.Parent.Parent;

            Console.WriteLine(rootFolder);

            PrintDirectoriesAndFiles(rootFolder, "-----");
        }

        public static void PrintDirectoriesAndFiles(DirectoryInfo rootFolder, string praefix)
        {
            FileInfo[] files = rootFolder.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(praefix + " File: " + file.Name);
            }

            DirectoryInfo[] subfolders = rootFolder.GetDirectories();

            foreach (DirectoryInfo folder in subfolders)
            {
                Console.WriteLine(praefix + " Ordner: " + folder.Name);

                PrintDirectoriesAndFiles(folder, praefix + "-----");
            }
        }

        public static void Traversal(DirectoryInfo rootFolder, string praefix, FileReceiver fileReceiver)
        {
            FileInfo[] files = rootFolder.GetFiles();

            foreach (FileInfo file in files)
            {
                fileReceiver.OnFileReceived(0, file.FullName);
            }

            DirectoryInfo[] subfolders = rootFolder.GetDirectories();

            foreach (DirectoryInfo folder in subfolders)
            {
                fileReceiver.OnDirectoryReceived(0, folder.FullName);

                Traversal(folder, praefix + "-----", fileReceiver);
            }
        }
    }
}

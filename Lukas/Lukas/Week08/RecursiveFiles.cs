
using System;
namespace Lukas.Week08
{
    public class RecursiveFiles
    {
        public RecursiveFiles()
        {
        }

        public static void Start()
        {
            string name = Directory.GetCurrentDirectory();

            Console.WriteLine(name);

            string rootFolder = new DirectoryInfo(name).Parent.Parent.Parent.Parent.FullName;

            Console.WriteLine(rootFolder);

            //PrintDirectoriesAndFiles(rootFolder, "-----");

            CalculateFileSizeReceiver fileReceiver = new CalculateFileSizeReceiver();
            Traversal(rootFolder, 0, fileReceiver);
            Console.WriteLine("Overall filesize is: " + fileReceiver.overallFileSizeInBytes);

            FileAndFolderCounter fileReceiver2 = new FileAndFolderCounter();
            Traversal(rootFolder, 0, fileReceiver2);
            Console.WriteLine("Files: " + fileReceiver2.CountFile + " Folders: " + fileReceiver2.CountFolder);

            PrintFileTreeReceiver fileReceiver3 = new PrintFileTreeReceiver();
            Traversal(rootFolder, 0, fileReceiver3);
        }

        public static void PrintDirectoriesAndFiles(string rootFolder, string praefix)
        {
            string[] files = Directory.GetFiles(rootFolder);

            foreach (string file in files)
            {
                Console.WriteLine(praefix + " File: " + new FileInfo(file).Name);
            }

            string[] subfolders = Directory.GetDirectories(rootFolder);

            foreach (string folder in subfolders)
            {
                Console.WriteLine(praefix + " Ordner: " + new DirectoryInfo(folder).Name);

                PrintDirectoriesAndFiles(folder, praefix + "-----");
            }
        }


        public static void Traversal(string rootFolder, int depth, FileReceiver fileReceiver)
        {
            string[] files = Directory.GetFiles(rootFolder);

            foreach (string file in files)
            {
                fileReceiver.OnFileReceived(depth, file);
            }

            string[] subfolders = Directory.GetDirectories(rootFolder);

            foreach (string folder in subfolders)
            {
                fileReceiver.OnDirectoryReceived(depth, folder);
                Traversal(folder, depth + 1, fileReceiver);
            }
        }
    }
}


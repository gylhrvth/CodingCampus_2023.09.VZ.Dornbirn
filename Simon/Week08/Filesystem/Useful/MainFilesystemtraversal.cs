using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class MainFilesystemtraversal
    {
        
        
        public static void Start()
        {
            string path = "C:\\Users\\aau21982\\source\\repos\\CodingCampus_2023.09.VZ.Dornbirn\\Simon\\Week01";
            CountFilesFolders countFilesFolders = new();
            SizeFiles sizeFiles = new SizeFiles();
            CountFileEnding countFileEnding = new("cs");

            //PrintFileTraversal(path);

            //string current = Directory.GetCurrentDirectory();
            //Console.WriteLine(current);

            FileTraversal(path, 0, countFilesFolders);
            Console.WriteLine($"Filecount: {countFilesFolders.FileCount}");
            Console.WriteLine($"Foldercount: {countFilesFolders.FolderCount}");
            FileTraversal(path, 0, sizeFiles);
            Console.WriteLine($"SummFilesize: {sizeFiles.Size}");
            FileTraversal(path, 0, countFileEnding);
            Console.WriteLine($"Files ending on cs: {countFileEnding.Count}");
        }


        public static void FileTraversal(string path, int depth, IFileReceiver fr)
        {
            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);
            foreach (string file in files)
            {
                fr.OnFileReceived(depth, file);
            }

            foreach (string directory in directories)
            {
                fr.OnDirectoryReceived(depth, directory);
                FileTraversal(directory, depth + 1, fr);
            }
        }

        //public static void PrintFileTraversal(string path)
        //{
        //    foreach (string file in files)
        //    {
        //        FileInfo fileInfo = new FileInfo(file);
        //        Console.WriteLine(fileInfo.Name);
        //    }
        //    foreach (string directory in directories)
        //    {
        //        DirectoryInfo directoryInfo = new DirectoryInfo(directory);
        //        Console.WriteLine(directoryInfo.Name);
        //        PrintFileTraversal(directory);
        //    }
        //}
        //public static void PrintFileTraversal(string path, string prefix)
        //{
        //    string[] directories = Directory.GetDirectories(path);
        //    string[] files = Directory.GetFiles(path);

        //    foreach (string file in files)
        //    {
        //        FileInfo pathfileInfo = new FileInfo(file);
        //        Console.WriteLine(prefix + pathfileInfo.Name);

        //    }

        //    foreach (string dir in directories)
        //    {
        //        DirectoryInfo pathDirectoryInfo = new DirectoryInfo(dir);
        //        Console.WriteLine(prefix + pathDirectoryInfo.Name);
        //        PrintFileTraversal(dir, prefix + "+++");
        //    }
        //}




    }
}

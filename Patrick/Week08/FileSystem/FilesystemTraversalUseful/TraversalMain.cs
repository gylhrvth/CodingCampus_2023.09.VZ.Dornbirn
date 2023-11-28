using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    public class TraversalMain
    {

        public static void Start()
        {

            string path = Directory.GetCurrentDirectory();
            string rootFolder = new DirectoryInfo(path).Parent.Parent.Parent.FullName;
            //Console.WriteLine(rootFolder);

            //Aufgabe1
            FileAndFolderCounter fileReceiver = new FileAndFolderCounter();
            Traversal(rootFolder, 0, fileReceiver);
            Console.WriteLine("Files: " + fileReceiver.CounterFile + " Folders: " + fileReceiver.CounterFolder);

            //Aufgabe2
            CalcFileSize calcFileSize = new CalcFileSize();
            Traversal(rootFolder, 0, calcFileSize);
            Console.WriteLine($"The Size of all Files is = {calcFileSize.FileSizeOverall} Bites");


            //Aufgabe3
            PrintFoldersAndFiles(rootFolder,"-- ");

            //Aufgabe4
            FindAndCountFile findAndCountFile = new FindAndCountFile();
            Traversal(rootFolder, 0, findAndCountFile);
            Console.WriteLine("Count of \".cs\" files: " + findAndCountFile.FileExtensionsCount[".cs"]);        //es wird nach .cs Dateien gesucht.
        }

        public static void Traversal(string rootFolder, int depth, IFilereceiver fileReceiver)
        {
            string[] files = Directory.GetFiles(rootFolder);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                fileReceiver.OnFileReceived(depth, fileInfo.FullName);
            }

            string[] folders = Directory.GetDirectories(rootFolder);
            foreach (string folder in folders)
            {
                DirectoryInfo folderInfo = new DirectoryInfo(folder);
                fileReceiver.OnDirectoryReceived(depth, folderInfo.Name);
                Traversal(folder, depth + 1, fileReceiver);
            }
        }

        public static void PrintFoldersAndFiles(string rootFolder, string prefix)
        {
            string[] files = Directory.GetFiles(rootFolder);

            foreach(string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(prefix + $"Filename: {fileInfo.Name} | FileSize {fileInfo.Length}");
                Console.ResetColor();
            }

            string[] folders = Directory.GetDirectories(rootFolder);
            foreach(string folder in folders)
            {
                DirectoryInfo folderInfo = new DirectoryInfo(folder);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(prefix + $"Foldername: {folderInfo.Name}");
                PrintFoldersAndFiles(folder, prefix + "-- ");
            }   
        }

    }
}

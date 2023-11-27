using Dimitri.Week08._03Test;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class Filesystem
    {

        public static string currentDir = Directory.GetCurrentDirectory();
        public static void Main()
        {
            //PrintDCVDirStructDepth0();


            DirectoryInfo projectRoot = GoToParentNTimes(3, currentDir);

            //long sizeOfAllFiles = SumOfFilesInDir(projectRoot.FullName);
            //Console.WriteLine("Size of all files in {0} is {1} Byte.", projectRoot.Name, sizeOfAllFiles);

            //NumberOfFilesAndDirs numberOfFilesAndDirs = new NumberOfFilesAndDirs();
            //CalculateSize totalFilesize = new CalculateSize();
            Console.WriteLine(projectRoot.FullName);
            //FilesystemTraversal("├──", projectRoot.FullName, totalFilesize);

            //Console.WriteLine("Number of dirs: {0}", numberOfFilesAndDirs.NumberOfDirs);
            //Console.WriteLine("Number of files: {0}", numberOfFilesAndDirs.NumberOfFiles);
            //Console.Write("Sum of all files: {0}B", totalFilesize.size);

            FileTraversal fileTraversal = new FileTraversal();

            FilesystemTraversalClass(1, projectRoot.FullName, fileTraversal);

        }

        public static void PrintDCVDirStructDepth0()
        {
            string currentDir = Directory.GetCurrentDirectory();

            string[] subDirs = Directory.GetDirectories(currentDir);

            DirectoryInfo projectRoot = GoToParentNTimes(4, currentDir);

            Console.WriteLine(projectRoot.FullName);

            string[] childrenRootDirs = Directory.GetDirectories(projectRoot.FullName);
            string[] childrenRootFiles = Directory.GetFiles(projectRoot.FullName);

            foreach (string childDir in childrenRootDirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(childDir);
                Console.WriteLine("d: {0}", dirInfo.Name);
            }

            foreach (string childFiles in childrenRootFiles)
            {
                FileInfo fileInfo = new FileInfo(childFiles);
                Console.WriteLine("f: {0} Size: {1} Byte", fileInfo.Name, fileInfo.Length);

            }

        }

        public static DirectoryInfo GoToParentNTimes(int n, string dir)
        {

            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            for (int i = 0; i < n; i++)
            {
                dirInfo = dirInfo.Parent;
            }

            return dirInfo;

        }

        public static long SumOfFilesInDir(string dir)
        {
            long size = 0;

            DirectoryInfo dirToCalc = new DirectoryInfo(dir);

            string[] filesInDir = Directory.GetFiles(dirToCalc.FullName);

            foreach (string file in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
            }

            return size;
        }



        //public static void FilesystemTraversal(string prefix, string dir, List<IFileReceiver> fileReceiver)
        //{
        //    prefix = "   " + prefix;
        //    string[] childrenRootDirs = Directory.GetDirectories(dir);
        //    string[] childrenRootFiles = Directory.GetFiles(dir);
        //    foreach (string childDir in childrenRootDirs)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        DirectoryInfo childDirInfo = new DirectoryInfo(childDir);
        //        fileReceiver.OnDirectoryReceived(depth, childDirInfo.FullName);
        //        Console.WriteLine("{0}{1}", prefix, childDirInfo.Name);
        //        Console.ResetColor();
        //        FilesystemTraversal(prefix, childDir, fileReceiver);
        //        depth++;

        //    }

        //    foreach (string childFile in childrenRootFiles)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        FileInfo childFileInfo = new FileInfo(childFile);
        //        fileReceiver.OnFileReceived(depth, childFileInfo.FullName);
        //        Console.WriteLine("{0}{1}", prefix, childFileInfo.Name);
        //        Console.ResetColor();
        //    }
        //}

        public static void FilesystemTraversalClass(int depth, string dir, IFileReceiver fileReceiver)
        {
            string[] childrenRootDirs = Directory.GetDirectories(dir);
            string[] childrenRootFiles = Directory.GetFiles(dir);
            foreach (string childDir in childrenRootDirs)
            {
                DirectoryInfo childDirInfo = new DirectoryInfo(childDir);
                fileReceiver.OnDirectoryReceived(depth, childDirInfo.FullName);
                FilesystemTraversalClass(depth +1, childDir, fileReceiver);
            }

            foreach (string childFile in childrenRootFiles)
            {
                FileInfo childFileInfo = new FileInfo(childFile);
                fileReceiver.OnFileReceived(depth, childFileInfo.FullName);
            }
        }

        //public static void FilesystemTraversalWithFileReceiverList(string prefix, string dir, IFileReceiver[] fileReceivers)
        //{
        //    prefix = "   " + prefix;
        //    string[] childrenRootDirs = Directory.GetDirectories(dir);
        //    string[] childrenRootFiles = Directory.GetFiles(dir);
        //    foreach (string childDir in childrenRootDirs)
        //    {
        //        foreach (IFileReceiver fileReceiver in fileReceivers)
        //        {
        //            DirectoryInfo childDirInfo = new DirectoryInfo(childDir);
        //            Console.Write(prefix);
        //            fileReceiver.OnDirectoryReceived(depth, childDirInfo.FullName);

        //            FilesystemTraversalClass(prefix, childDir, fileReceiver);

        //        }
        //        depth++;

        //    }

        //    foreach (string childFile in childrenRootFiles)
        //    {
        //        foreach (IFileReceiver fileReceiver in fileReceivers)
        //        {
        //            FileInfo childFileInfo = new FileInfo(childFile);
        //            Console.Write(prefix);
        //            fileReceiver.OnFileReceived(depth, childFileInfo.FullName);
        //            Console.ResetColor();
        //        }
        //   }
    //}

    }
}


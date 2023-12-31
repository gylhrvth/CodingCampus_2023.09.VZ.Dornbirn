﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Niklas.Week08.Filesystem
{
    internal class Files
    {
        public static void Start()
        {
            FilesAndFolders();
            Console.WriteLine();
            FolderSize();
            Console.WriteLine();
            Traversal();
            Console.WriteLine();
        }
        public static void FilesAndFolders()
        {
            string directory = Directory.GetCurrentDirectory();
            Console.WriteLine(directory);
            //DirectoryInfo info = new DirectoryInfo(directory);

            string[] children = Directory.GetFiles(directory);

            foreach (var child in children)
            {
                Console.WriteLine(child);
            }


            var currentDirectoryInfo = new DirectoryInfo(directory);
        }
        public static void FolderSize()
        {
            string directory = Directory.GetCurrentDirectory();
            Console.WriteLine(directory);
            DirectoryInfo DirInfo = new DirectoryInfo(directory);

            string[] children = Directory.GetFiles(directory);

            foreach (var child in children)
            {
                FileInfo fInfo = new FileInfo(child);
                Console.WriteLine(fInfo.Name + " " + Math.Round(ConvertToMByte(fInfo.Length), 2) + "MB");
            }
        }
        public static void Traversal()
        {
            string directory = Directory.GetCurrentDirectory();

            var currentDirectoryInfo = new DirectoryInfo(directory);

            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.FullName;
            Console.WriteLine(projectRootDirectory);

            string[] directoryChildren = Directory.GetDirectories(projectRootDirectory);

            foreach (var dir in directoryChildren)
            {
                //Weeks
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                if (dirInfo.Name.Contains("Week"))
                {
                    Console.WriteLine(Convert.ToChar(9568) + dirInfo.Name);
                }

                var childchild = dirInfo.GetDirectories();

                //Files in folders of week
                foreach (var printfiles in childchild)
                {

                    if (!printfiles.Name.Contains("Debug") && !printfiles.Name.Contains("Release"))
                    {
                        Console.WriteLine(Convert.ToChar(9553) + " " + "" + Convert.ToChar(9562) + "" + Convert.ToChar(9552) + printfiles.Name);
                    }
                    var foldersInFolders = printfiles.GetFiles();
                    foreach (var files in foldersInFolders)
                    {
                        Console.WriteLine(Convert.ToChar(9553) + "     " + Convert.ToChar(9562) + files.Name);
                    }
                }

                var getfiles = dirInfo.GetFiles();

                //Files in week
                foreach (var printfiles in getfiles)
                {
                    if (!printfiles.Name.Contains("Niklas") && printfiles.Name.Contains(".cs"))
                    {
                        Console.WriteLine(Convert.ToChar(9553) + "  " + Convert.ToChar(9562) + printfiles.Name);
                    }
                }
            }
        }

        public static float ConvertToMByte(long sizeInByte)
        {
            return sizeInByte / 1024.0f / 1024;
        }
    }
}

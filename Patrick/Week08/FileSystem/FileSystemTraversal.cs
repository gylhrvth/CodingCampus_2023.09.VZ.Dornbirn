using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patrick.Week08.FileSystem
{
    internal class FileSystemTraversal
    {
        public static void Start()
        {

            string path = Directory.GetCurrentDirectory();
            string rootFolder = new DirectoryInfo(path).Parent.Parent.Parent.FullName;

            //Console.WriteLine(rootFolder);

            PrintFoldersAndFiles(rootFolder, "-- ");

        }

        public static void PrintFoldersAndFiles(string rootfolder, string prefix)
        {
            string[] files = Directory.GetFiles(rootfolder);

            foreach(string file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                Console.WriteLine(prefix + " Files " + fileinfo.Name);
            }

            string[] folders = Directory.GetDirectories(rootfolder);

            foreach(string folder in folders)
            {
                DirectoryInfo folderinfo = new DirectoryInfo(folder);
                Console.WriteLine(prefix + " Folder: " + folderinfo.Name);
                PrintFoldersAndFiles(folder, prefix + "-- ");                             //Gyula fragen warum prefix + prefix sich verdoppelt??
            }

        }
    }
}

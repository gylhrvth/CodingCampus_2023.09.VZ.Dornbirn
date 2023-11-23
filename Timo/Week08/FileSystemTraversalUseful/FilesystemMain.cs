using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    public class FilesystemMain
    {
        public static void Start()
        {
            string path = "C:\\Users\\aau27722\\source\\Repos\\CodingCampus_2023.09.VZ.Dornbirn\\Timo";
            ////Zählen
            //Counter count = new();
            //NavigateFileSystem(0, path, count);
            //Console.WriteLine("Filecount: {0}", count.GetFileCount());
            //Console.WriteLine("Directorycount: {0}", count.GetDirectoryCount());
            ////Größe
            //Filesize filesize = new Filesize();
            //NavigateFileSystem(0, path, filesize);
            //Console.WriteLine("size of all files: {0} KB", ConverttoKB(filesize.GetFileSize()));
            ////Ausgabe
            //Filesystem filesystem = new ();
            //NavigateFileSystem(0, path, filesystem);
            //Extentioncount
            CountEnd extentionCount = new(".cs");
            NavigateFileSystem(0, path, extentionCount);
            Console.WriteLine("Files ending with \".cs\": {0}", extentionCount.ExtentionCount());
        }

        public static void NavigateFileSystem(int depth, string path, IFileReceiver fr) 
        {
            string[] files = Directory.GetFiles(path);
            string[] directionaries = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                fr.OnFileReceived(depth, file);
            }
            foreach (var direction in directionaries)
            {
                fr.OnDirectoryReceived(depth, direction);
                NavigateFileSystem(depth+1, direction, fr);
            }
        }
        public static float ConverttoKB(long sizeInByte)
        {
            return sizeInByte / 1024.0f;
        }
    }
}

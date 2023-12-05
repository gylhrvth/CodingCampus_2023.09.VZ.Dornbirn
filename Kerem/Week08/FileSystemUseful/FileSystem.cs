using Kerem.Week08.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.FileSystemUseful
{
    public class FileSystem : IFileReceiver
    {
        public void OnFileReceived(int depth, string path)
        {
            string prefix = new string(' ', depth * 4);
            DirectoryInfo directory = new DirectoryInfo(path);
            Console.WriteLine($"{prefix}├── {directory.Name}");

        }

        public void OnDirectoryReceived(int depth, string path) 
        {
            string prefix = new string(' ', depth * 4);
            FileInfo file = new FileInfo(path);
            Console.WriteLine($"{prefix}├── {file.Name}");

        }
    }
}

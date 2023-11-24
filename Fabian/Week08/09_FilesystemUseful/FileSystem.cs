using Fabian.Week08._09_FilesystemUsefull;
using System.IO;

namespace Fabian.Week08
{
    public class FileSystem : IFileReceiver
    {
        public void OnDirectoryReceived(int depth, string path)
        {
            string prefix = new string(' ', depth * 4);
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine($"{prefix}├── {dir.Name}");
        }

        public void OnFileReceived(int depth, string path)
        {
            string prefix = new string(' ', depth * 4);
            FileInfo fi = new FileInfo(path);
            Console.WriteLine($"{prefix}├── {fi.Name}");
        }
    }
}



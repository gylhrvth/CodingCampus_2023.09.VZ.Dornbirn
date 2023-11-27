using Fabian.Week08._09_FilesystemUsefull;

namespace Fabian.Week08
{
    public class FileSystem : IFileReceiver
    {
        public void OnDirectoryReceived(int depth, string path)
        {
            string prefix = new string(' ', depth * 4);
            Console.WriteLine($"{prefix}├── {Path.GetFileName(path)}");
        }

        public void OnFileReceived(int depth, string path)
        {
            string prefix = new string(' ', depth * 4);
            Console.WriteLine($"{prefix}├── {Path.GetFileName(path)}");
        }
    }
}



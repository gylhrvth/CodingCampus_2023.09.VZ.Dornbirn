using static Fabian.Week08._09_FilesystemUsefull.FilesystemMain;

namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FolderSizeCalculator : IFileReceiver
    {
        private Dictionary<string, long> _FolderSizes = new Dictionary<string, long>();
        public void OnFileReceived(int depth, string path)
        {

        }

        public void OnDirectoryReceived(int depth, string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            long directorySize = 0;
            string prefix = new(' ', depth * 4);
            foreach (var file in Directory.GetFiles(path))
            {
                FileInfo fi = new FileInfo(file);
                directorySize += fi.Length;
            }
            //foreach (var subdir in Directory.GetDirectories(path))
            //{
            //    NavigateFileSystem(depth + 1, subdir, new List<IFileReceiver> { this });
            //    directorySize += _FolderSizes[subdir];
            //}

            if (_FolderSizes.ContainsKey(dir.Name))
                _FolderSizes[prefix + dir.Name] += directorySize;
            else
                _FolderSizes[prefix + dir.Name] = directorySize;
        }
        

        public void PrintFolderSizes()
        {
            foreach (var kvp in _FolderSizes)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value} bytes");
            }
        }
    }
}

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
            foreach (var file in Directory.GetFiles(path))
            {
                FileInfo fi = new FileInfo(file);
                if (dir.Exists)
                {
                    if (_FolderSizes.ContainsKey(dir.Name))
                        _FolderSizes[dir.Name] += fi.Length;
                    else
                        _FolderSizes[dir.Name] = fi.Length;
                }
            }
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

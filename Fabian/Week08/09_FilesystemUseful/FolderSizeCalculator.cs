using static Fabian.Week08._09_FilesystemUsefull.FilesystemMain;

namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FolderSizeCalculator : IFileReceiver
    {
        private Dictionary<string, (long, string)> _FolderSizes = new Dictionary<string, (long, string)>();

        public void OnFileReceived(int depth, string path)
        {
        }

        public void OnDirectoryReceived(int depth, string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                long directorySize = 0;
                string prefix = new(' ', depth * 4);
                foreach (var file in Directory.GetFiles(path))
                {
                    FileInfo fi = new FileInfo(file);
                    directorySize += fi.Length;
                }

                if (!_FolderSizes.ContainsKey(path))
                    _FolderSizes[path] = (returnSize(path), prefix);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }
        public void PrintFolderSizes()
        {
            foreach (var kvp in _FolderSizes)
            {
                DirectoryInfo di = new(kvp.Key);
                Console.WriteLine($"{kvp.Value.Item2}{di.Name} : {kvp.Value.Item1} bytes");
            }
        }

        public long returnSize(string path)
        {
            var files = Directory.GetFiles(path);
            var dirs = Directory.GetDirectories(path);

            long sum = 0;

            foreach(var file in files)
            {
                FileInfo fi = new FileInfo(file);
                sum += fi.Length;
            }

            foreach(var subdir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(subdir);
                sum += returnSize(dirInfo.FullName);
            }
            return sum;
        }
    }
}

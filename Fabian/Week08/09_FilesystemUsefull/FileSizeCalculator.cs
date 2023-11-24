
namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FileSizeCalculator : IFileReceiver
    {

        private long _TotalSize = 0;
        public void OnFileReceived(int depth, string path)
        {
            FileInfo fi = new(path);
            if (fi.Exists)
                _TotalSize += fi.Length;
        }
        public long GetTotalSize()
        {
            return _TotalSize;
        }
        public void OnDirectoryReceived(int depth, string path) { }
    }
}

namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FolderSizeCalculator : IFileReceiver
    {
        private long _TotalSize = 0;
        public void OnFileReceived(int depth, FileInfo fi)
        {
            _TotalSize += fi.Length;
        }
        public long GetTotalSize()
        {               
            return _TotalSize;
        }
    }
}

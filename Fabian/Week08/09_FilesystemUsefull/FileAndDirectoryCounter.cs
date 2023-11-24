
namespace Fabian.Week08._09_FilesystemUsefull
{
    internal class FileAndDirectoryCounter : IFileReceiver
    {
        private int _FileCounter = 0;
        private int _DirectoryCounter = 0;
        public void OnDirectoryReceived(int depth, string path)
        {
            _DirectoryCounter++;
        }

        public void OnFileReceived(int depth, string path)
        {
            _FileCounter++;
        }

        public int GetFileCounter()
        {
            return _FileCounter;
        }
        public int GetDirectoryCounter()
        {
            return _DirectoryCounter;
        }
    }
}

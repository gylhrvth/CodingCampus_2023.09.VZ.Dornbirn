namespace Fabian.Week08._09_FilesystemUsefull
{
    public interface IFileReceiver
    {
        public void OnFileReceived(int depth, string path);
        public void OnDirectoryReceived(int depth, string path);
    }
}

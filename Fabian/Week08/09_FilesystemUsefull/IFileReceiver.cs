namespace Fabian.Week08._09_FilesystemUsefull
{
    public interface IFileReceiver
    {
        public void OnFileReceived(int depth, FileInfo fi);
    }
}


namespace Fabian.Week08._09_FilesystemUsefull
{
    public class FileExtensionCounter : IFileReceiver
    {
        private string extension;
        private int counter;

        public FileExtensionCounter(string extension)
        {
            this.extension = extension;
        }

        public void OnDirectoryReceived(int depth, string path)
        {
            
        }

        public void OnFileReceived(int depth, string path)
        {
            if (path.EndsWith(extension))
                counter++;
        }
        
        public int GetFileCounter()
        {
            return counter;
        }
    }
}

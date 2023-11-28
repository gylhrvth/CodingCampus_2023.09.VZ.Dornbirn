using System;
namespace Mohammed.Week08.Filesystem2
{
    public class FileExtensisonsCounter 
    {

        private int _CountFolder = 0;
        private int _CountFile = 0;

        public int CountFolder { get => _CountFolder; }
        public int CountFile { get => _CountFile; }

        public FileExtensisonsCounter()
        {
        }

        public void OnFileReceived(int depth, string path)
        {
            _CountFile++;

        }

        public void OnDirectoryReceived(int depth, string path)
        {
            _CountFolder++;
        }
}    }



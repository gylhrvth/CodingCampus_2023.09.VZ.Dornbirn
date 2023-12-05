using Kerem.Week08.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.FileSystemUseful
{
    internal class FileAndDirectoryCounter : IFileReceiver
    {
        private int _FileCounter;
        private int _DirectoryCounter;

        public int FileCounter { get => _FileCounter; }
        public int DirectoryCounter { get => _DirectoryCounter; }

        public FileAndDirectoryCounter()
        {

        }
        public void OnFileReceived(int depth, string path)
        {
          _FileCounter++;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            _DirectoryCounter++;
        }
    }
}

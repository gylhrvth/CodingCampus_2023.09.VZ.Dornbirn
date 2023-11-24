using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week08._04Filesystem
{
    internal class NumberOfFilesAndDirs : IFileReceiver
    {
        private int _NumberOfDirs = 0;
        private int _NumberOfFiles = 0;

        public int NumberOfFiles
        {
            get => _NumberOfFiles;
        }

        public int NumberOfDirs
        {
            get => _NumberOfDirs;
        }
        public void OnFileReceived(int depth, string path)
        {
            _NumberOfFiles++;
        }
        public void OnDirectoryReceived(int depth, string path)
        {
            _NumberOfDirs++;
        }
    }
}

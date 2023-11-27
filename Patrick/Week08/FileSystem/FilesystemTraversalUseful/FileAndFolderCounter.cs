using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    public class FileAndFolderCounter : IFilereceiver
    {
        private int _CounterFolder = 0;
        private int _CounterFile = 0;

        public int CounterFolder
        {
            get => _CounterFolder;
        }

        public int CounterFile
        {
            get => _CounterFile;
        }


        public FileAndFolderCounter()
        {
          
        }



        public void OnFileReceived(int depth, string rootFolder)
        {
           _CounterFile++;
        }

        public void OnDirectoryReceived(int depth, string rootFolder)
        {
            _CounterFolder++;
        }
    }
}

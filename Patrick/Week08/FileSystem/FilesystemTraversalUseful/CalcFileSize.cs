using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.FileSystem.FilesystemTraversalUseful
{
    public class CalcFileSize : IFilereceiver
    {
        private long _FileSizeOverall = 0;

        public long FileSizeOverall
        {
            get => _FileSizeOverall;
        }
        public CalcFileSize()
        {

        }

        public void OnFileReceived(int depth, string rootFolder)
        {
            FileInfo fileInfo = new FileInfo(rootFolder);   
            _FileSizeOverall += fileInfo.Length;
        }
        public void OnDirectoryReceived(int depth, string rootFolder)
        {

        }






    }
}

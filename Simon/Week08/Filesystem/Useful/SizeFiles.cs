using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class SizeFiles : IFileReceiver
    {
        private long _Size;
        public SizeFiles()
        {
            _Size = 0;
        }
        public long Size { get { return _Size; } }

        public void OnFileRecived(int depth, string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            _Size += fileInfo.Length;
            Console.WriteLine(_Size + fileInfo.Name + fileInfo.Length);
            //DirectoryInfo directoryInfo = new DirectoryInfo(path);
            //FileInfo[] files = directoryInfo.GetFiles();
            //foreach(FileInfo file in files)
            //{
            //    _Size += file.Length;
            //    Console.WriteLine(_Size + file.Name);
            //}            
        }

        public void OnDirectoryReceived(int depth, string path)
        {

        }
    }
}

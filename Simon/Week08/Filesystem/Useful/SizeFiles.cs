using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week08.Filesystem.Useful
{
    public class SizeFiles : IFileReceiver
    {
        private int _Size;
        public SizeFiles(int size)
        {
            _Size = size;
        }
        public int Size {  get { return _Size; } }

        public void OnFileRecieved()
        {
<<<<<<< HEAD
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
=======

>>>>>>> 9f87552f42c4104cfae8cf02fca03992d0b643d4
        }

        public void OnDirectoryRecieved()
        {

        }

    }
}

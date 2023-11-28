using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week08.FileWalker
{
    internal class FileWalker
    {
        private List<IFileProcessor> fp;

        public FileWalker()
        {
            this.fp = new List<IFileProcessor>();
        }

        public void addFileProcessor(IFileProcessor processor)
        {
            if (!fp.Contains(processor))
            {
                fp.Add(processor);
            }
        }

        //public void process(string startFile)
        //{
        //    process(0, startFile);
        //}

        //private void process(int depth, string startFile)
        //{
        //    foreach (IFileProcessor processor in fp)
        //    {
        //        processor.onFileReceived(depth, startFile);
        //    }
        //    if (startFile.isDirectory())
        //    {
        //        File[] fList = startFile.listFiles();
        //        for (int i = 0; i < fList.length; i++)
        //        {
        //            process(depth + 1, fList[i]);
        //        }
        //    }
        //}
    }
}

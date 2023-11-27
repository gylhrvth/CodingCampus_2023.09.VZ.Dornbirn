using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week08.FileWalker
{
    internal class FileWalkerMain
    {

        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);
            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.Parent.FullName;



            //FileWalker fw = new FileWalker();
            //fw.addFileProcessor(new FileReceiver());
            //fw.addFileProcessor(new FileSizeSum());

            //fw.process(projectRootDirectory);


        }


    }
}

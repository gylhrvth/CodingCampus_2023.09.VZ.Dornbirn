﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08.FileSystemTraversalUseful
{
    public interface IFileReceiver
    {
        public void OnFileReceived(int depth, string path);
        public void OnDirectoryReceived(int depth, string path);
    }
}

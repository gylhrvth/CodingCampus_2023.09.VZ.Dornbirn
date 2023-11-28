using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week08.FilesByLuki
{
        public interface FileReceiver
        {
            void OnFileReceived(string file);
        }
        class FileSizeReceiver : FileReceiver
        {
            private long Size = 0;
            private long FileCount = 0;
            public void OnFileReceived(string file)
            {
                Size += new FileInfo(file).Length;
                FileCount++;
            }
            public override string ToString()
            {
                return "Overall file size: " + string.Format("{0:0.00}", Size / 1024.0 / 1024.0) + "mb\nFiles: " + FileCount;
            }
        }
        public class Files2
        {
            public Files2()
            {
            }
            public static void Start()
            {
                FileReceiver fileReceiver = new FileSizeReceiver();
                DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory());
                string folder = info.Parent.Parent.Parent.Parent.Parent.FullName;
                Console.WriteLine(folder);
                Traverse2(folder, fileReceiver);
                Console.WriteLine("Overall size in bytes: " + fileReceiver);
            }
            public static void Traverse(string path, FileReceiver fileReceiver)
            {
                if (Directory.Exists(path))
                {
                    foreach (string child in Directory.GetFiles(path))
                    {
                        Traverse(child, fileReceiver);
                        //Console.WriteLine("    f: " + child);
                    }
                    foreach (string child in Directory.GetDirectories(path))
                    {
                        //Console.WriteLine("    d: " + child);
                        Traverse(child, fileReceiver);
                    }
                }
                else if (File.Exists(path))
                {
                    fileReceiver.OnFileReceived(path);
                }
            }
            public static void Traverse2(string path, params FileReceiver[] fileReceiver)
            {
                if (Directory.Exists(path))
                {
                    foreach (string child in Directory.GetFiles(path))
                    {
                        Traverse2(child, fileReceiver);
                        //Console.WriteLine("    f: " + child);
                    }
                    foreach (string child in Directory.GetDirectories(path))
                    {
                        //Console.WriteLine("    d: " + child);
                        Traverse2(child, fileReceiver);
                    }
                }
                else if (File.Exists(path))
                {
                    foreach (FileReceiver receiver in fileReceiver)
                    {
                        receiver.OnFileReceived(path);
                    }
                }
            }
        }
    }


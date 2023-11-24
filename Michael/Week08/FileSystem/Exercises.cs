using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week08.FileSystem
{

    internal class Exercises
    {
        public static void ShowFilesAndDirectories(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine($"{fileInfo.Length} - {fileInfo.Name}");
            }

            foreach(string dir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                Console.WriteLine(dirInfo.Name);
            }
        }


        public static long GetFirstLayerSize(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            long sum = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            return sum;
        }


        public static void PrintCurrentFolder(string directory, string prefix = "")
        {
            string[] files = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Console.WriteLine($"{prefix}{fileInfo.Length} - {fileInfo.Name}");
            }

            foreach (string dir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{prefix}{dirInfo.Name}");
                PrintCurrentFolder(dirInfo.FullName, prefix + "  ");
            }
        }


        public static void ReadFile(string path)
        {
            using (FileStream file = File.OpenRead(path))
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] buffer = new byte[1024];
                int read = file.Read(buffer, 0, buffer.Length);

                while (read != 0)
                {
                    Console.Write(encoding.GetString(buffer, 0, read));
                    read = file.Read(buffer, 0, buffer.Length);
                }
            }
        }


        public static void WriteFile(string path)
        {
            using (FileStream file = File.OpenWrite(path))
            {
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] buffer = new byte[1024];

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "ende") return;

                    buffer = encoding.GetBytes(input);

                    file.Write(buffer, 0, buffer.Length);
                }
            }
        }


        public static void CopyFromTo(string path1, string path2)
        {
            byte[] buffer = new byte[1024];
            using (FileStream readFile = File.OpenRead(path1))
            {
                using (FileStream writeFile = File.OpenWrite(path2))
                {
                    int read = readFile.Read(buffer, 0, buffer.Length);

                    while (read != 0)
                    {
                        writeFile.Write(buffer, 0, buffer.Length);
                        read = readFile.Read(buffer, 0, buffer.Length);
                    }

                }
            }
        }


        public static void CopyFromToShout(string path1, string path2)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] buffer = new byte[1024];
            using (FileStream readFile = File.OpenRead(path1))
            {
                using (FileStream writeFile = File.OpenWrite(path2))
                {
                    int read = readFile.Read(buffer, 0, buffer.Length);

                    while (read != 0)
                    {
                        string stuff = encoding.GetString(buffer, 0, read);
                        stuff = stuff.ToUpper();
                        buffer = encoding.GetBytes(stuff);
                        writeFile.Write(buffer, 0, buffer.Length);
                        read = readFile.Read(buffer, 0, buffer.Length);
                    }

                }
            }
        }


        public static void ReadMaze()
        {
            string path = "C:\\Users\\michi\\OneDrive\\Desktop\\Labyrinth.png";

            using (FileStream readFile = File.OpenRead(path))
            {
                byte[] buffer = new byte[1024];
                int read = readFile.Read(buffer, 0, 1);

                while (read != 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        Console.Write(buffer[i]);
                    }
                    Console.WriteLine();
                    read = readFile.Read(buffer, 0, buffer.Length);
                }
            }
        }
    }





    
    public interface IFileReceiver
    {
        public void OnFileReceived(int depth, string path);

        public void OnDirectoryReceived(int depth, string path);
    }

    public class ProperFileReceiver : IFileReceiver
    {
        public void OnDirectoryReceived(int depth, string path) { }

        public void OnFileReceived(int depth, string path)
        {

        }
    }

    public class DirectoryReceiver : IFileReceiver
    {
        public void OnFileReceived(int depth, string path) { }

        public void OnDirectoryReceived(int depth, string path)
        {

        }
    }
    
}

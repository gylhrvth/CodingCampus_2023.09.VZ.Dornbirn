using System;

namespace Erik.Week09.Filesystem
{
    internal class DirectoryClass
    {
        public static void Start()
        {
            GetCurrentDirectoryAndFiles();
            var dirParent = RepeatDirectoryParent(new DirectoryInfo(Directory.GetCurrentDirectory()), 3);
            Console.Write("> > > " + dirParent);
            Console.WriteLine(" / " + GetFilesSizeInByte(dirParent, 4) + "mb");
        }

        public static void GetCurrentDirectoryAndFiles()
        {
            var dir = Directory.GetCurrentDirectory();
            Console.WriteLine(dir + " / " + dir.Length);
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            ParentCurrentDirectory(directoryInfo);
        }

        public static void ParentCurrentDirectory(DirectoryInfo dirInfo)
        {
            var dirParent = dirInfo.Parent.Parent.Parent;
            Console.WriteLine(dirParent);
        }

        public static DirectoryInfo RepeatDirectoryParent(DirectoryInfo root, int stepsBack)
        {
            var currentDir = root;

            for (int i = 0; i < stepsBack; i++)
            {
                currentDir = currentDir.Parent;
                if (currentDir == null)
                {
                    return null;
                }
            }
            return currentDir;
        }

        public static double GetFilesSizeInByte(DirectoryInfo dir, int decimals = 15)
        {
            double sumInByte = 0;
            foreach (FileInfo fileInfo in dir.GetFiles())
            {
                sumInByte += fileInfo.Length;
            }

            foreach(DirectoryInfo dirInfo in dir.GetDirectories())
            {
                sumInByte += GetFilesSizeInByte(dirInfo)*1024*1024;
            }

            double sumInMb = Math.Round(sumInByte / 1024 / 1024, decimals);
            return sumInMb;
        }

        
    }
}

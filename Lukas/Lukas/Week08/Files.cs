using System;
namespace Lukas.Week08
{
    public class Files
    {
        public Files()
        {
        }

        public static void Start()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            Console.WriteLine("---Children Files---");

            string[] children = Directory.GetFiles(currentDirectory);

            foreach (var child in children)
            {
                FileInfo fileInfo = new FileInfo(child);

                Console.WriteLine(fileInfo.Name + " " + Math.Round(ConvertToMByte(fileInfo.Length), 2) + "mb");
            }

            Console.WriteLine("---Children Directories---");

            var currentDirectoryInfo = new DirectoryInfo(currentDirectory);

            string projectRootDirectory = currentDirectoryInfo.Parent.Parent.Parent.Parent.Parent.FullName;

            Console.WriteLine("Project root directory: " + projectRootDirectory);

            string[] directoryChildren = Directory.GetDirectories(projectRootDirectory);

            directoryChildren = BubbleSortStringLex(directoryChildren, false);

            foreach (var directory in directoryChildren)
            {
                DirectoryInfo info = new DirectoryInfo(directory);
                Console.WriteLine(info.Name);
            }
        }

        public static float ConvertToMByte(long sizeInByte)
        {
            return sizeInByte / 1024.0f / 1024;
        }

        public static string[] BubbleSortStringLex(string[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0 && asc == true)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j].CompareTo(arr[j + 1]) < 0 && asc == false)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            return arr;
        }
    }
}


namespace Fabian.Selftest_OP
{
    internal class _06
    {
        public static void Start()
        {
            string path = @"C:\Users\fakr\source\repos\CodingCampus_2023.09.VZ.Dornbirn\Fabian";
            List<string> biggestFiles = GetBiggestFiles(path, 15);
            biggestFiles = SortList(biggestFiles);
            foreach (string file in biggestFiles)
                PrintFile(file);
        }
        public static List<string> GetBiggestFiles(string path, int count)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory isn't valid");
                return new List<string>();
            }
            else if (count <= 0)
            {
                Console.WriteLine("count can't be 0 or below");
                return new List<string>();
            }

            List<string> biggestFiles = new();
            GetBiggestFilesRecursive(path, biggestFiles, count);

            return biggestFiles;
        }
        public static void GetBiggestFilesRecursive(string path, List<string> biggestFiles, int count, long max = 0)
        {
            string[] files;
            string[] directories;
            try
            {
                files = Directory.GetFiles(path);
                directories = Directory.GetDirectories(path);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
                return;
            }

            foreach (string file in files)
            {

                if (!File.Exists(file)) continue;

                FileInfo fi = new(file);
                if ((fi.Length > max || biggestFiles.Count < count) /*&& file.EndsWith(".cs")*/)
                {
                    if (biggestFiles.Count == count)
                    {
                        string smallestFile = GetSmallestFileInList(biggestFiles);
                        if (fi.Length > new FileInfo(smallestFile).Length)
                        {
                            biggestFiles.Remove(smallestFile);
                            biggestFiles.Add(file);
                        }
                    }
                    else biggestFiles.Add(file);

                    max = GetMinLengthInList(biggestFiles);
                }
            }

            foreach (string dir in directories)
                GetBiggestFilesRecursive(dir, biggestFiles, count, max);
        }
        public static void PrintFile(string file)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"file: {Path.GetFileName(file)}, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"size: {new FileInfo(file).Length} B. ");
            Console.ResetColor();
            Console.WriteLine($"path: {file}");
        }
        public static long GetMinLengthInList(List<string> list)
        {
            long min = long.MaxValue;
            foreach (string file in list)
                if (new FileInfo(file).Length < min) min = file.Length;
            return min;
        }
        public static string GetSmallestFileInList(List<string> list)
        {
            string smallestFile = list[0];
            foreach (string file in list)
                if (new FileInfo(file).Length < new FileInfo(smallestFile).Length)
                    smallestFile = file;
            return smallestFile;
        }
        public static List<string> SortList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count - i - 1; j++)
                    if (new FileInfo(list[j]).Length < new FileInfo(list[j + 1]).Length)
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
            return list;
        }
    }
}


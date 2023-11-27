namespace Fabian.Selftest_OP
{
    internal class _06
    {
        public static void Start()
        {
            string path = @"C:\Users\Anwender\source\repos\CodingCampus_2023.09.VZ.Dornbirn";
            List<string> biggestFiles = GetBiggestFiles(path, 5);
            biggestFiles = SortList(biggestFiles);
            foreach (string file in biggestFiles)
                PrintFile(file);
        }
        public static List<string> GetBiggestFiles(string path, int count)
        {
            if (!Directory.Exists(path) || count <= 0) return new List<string>();

            List<string> biggestFiles = new List<string>();
            GetBiggestFilesRecursive(path, biggestFiles, count);

            return biggestFiles;
        }
        public static void GetBiggestFilesRecursive(string path, List<string> biggestFiles, int count, long max = 0)
        {
            string[] files = Directory.GetFiles(path);
            string[] directiories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                if(!File.Exists(file)) continue;

                FileInfo fi = new FileInfo(file);
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
            foreach (string dir in directiories)
                GetBiggestFilesRecursive(dir, biggestFiles, count, max);
        }
        public static void PrintFile(string file)
        {
            Console.WriteLine($"file: {file}, size: {new FileInfo(file).Length} B");
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
            long smallestSize = long.MaxValue;

            foreach (string file in list)
            {
                long fileSize = new FileInfo(file).Length;
                if (fileSize < smallestSize)
                {
                    smallestFile = file;
                    smallestSize = fileSize;
                }
            }
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


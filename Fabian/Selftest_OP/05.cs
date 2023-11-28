namespace Fabian.Selftest_OP
{
    internal class _05
    {
        public static void Start()
        {
            string path = @"C:\Users\Anwender\source\repos\CodingCampus_2023.09.VZ.Dornbirn";
            PrintFile(GetBiggestFile(path));
        }

        public static string GetBiggestFile(string path, string biggestFilePath = "", long max = 0)
        {
            if(!Directory.Exists(path)) return "";

            string[] files = Directory.GetFiles(path);
            string[] directiories = Directory.GetDirectories(path);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Length > max)
                {
                    biggestFilePath = file;
                    max = fi.Length;
                }
            }
            foreach (string dir in directiories)
            {
                biggestFilePath = GetBiggestFile(dir, biggestFilePath, max);
                max = new FileInfo(biggestFilePath).Length;
            }
            return biggestFilePath;
        }

        public static void PrintFile(string file)
        {
            if(File.Exists(file))
                Console.WriteLine($"file: {file}, size: {new FileInfo(file).Length} B");
            else
                Console.WriteLine("File not found");
        }
    }
}

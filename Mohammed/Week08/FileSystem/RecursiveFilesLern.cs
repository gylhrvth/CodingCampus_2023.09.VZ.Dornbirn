//using System;
//namespace Mohammed.Week08
//{

//    public class RecursiveFilesLern
//    {
//        public RecursiveFilesLern()
//        {
//        }

        //public static void Start()
        //{
        //    string name = Directory.GetCurrentDirectory();
        //    Console.WriteLine(name);

        //    string rootfolder = new DirectoryInfo(name).Parent.Parent.Parent.Parent.FullName;
        //    Console.WriteLine(rootfolder);

        //    Traversal(rootFolder, 0, fileReceiver);
        //}
    //}

    //public static void PrintDirectoriesAndFiles(string rootFolder, string praefix)
    //{
    //    string[] files = Directory.GetFiles(rootFolder);

    //    foreach (string file in files)
    //    {
    //        Console.WriteLine(praefix + "File: " + new FileInfo(file).Name);

    //    }

    //    string[] subfolders = Directory.GetDirectories(rootFolder);

    //    foreach (string folder in subfolders)
    //    {
    //        Console.WriteLine(praefix + "Ordner" + new DirectoryInfo(folder).Name);

    //        PrintDirectoriesAndFiles(folder, praefix + "======");
    //    }
    //}

    //public static void Traversal(string rootFolder, int depth, FileReceiver fileReceiver)
    //{
    //    string[] files = Directory.GetFiles(rootFolder);
    //    foreach (string file in files)
    //    {
    //        fileReceiver.OnFileReceiver(depth, file);
    //    }

    //    string[] subfolders = Directory.GetDirectories(rootFolder);

    //    foreach (string folder in subfolders)
    //    {
    //        fileReceiver.OnDirectoryReceived(depth, folder);
    //        Traversal(folder, depth + 1, fileReceiver);
    //    }
//    }
//}



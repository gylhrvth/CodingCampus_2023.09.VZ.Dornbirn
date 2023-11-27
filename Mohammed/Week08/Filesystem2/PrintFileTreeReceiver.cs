//using System;
//namespace Mohammed.Week08.Filesystem2
//{
//	public class PrintFileTreeReceiver : FileReceiver
//	{
//		public PrintFileTreeReceiver()
//		{
//		}

//		public void PrintIndention(int depth)
//		{
//			for (int i = 0; i < depth; i++)
//			{
//				Console.Write("==");
//			}
//		}

//		public void OnFileReceived(int depth, string path)
//		{
//			PrintIndention(depth);
//			Console.WriteLine(new FileInfo(path).Name);
//		}

//		public void OnDirectoryReceived(int depth, string path)
//		{
//			PrintIndention(depth);
//			Console.WriteLine(new DirectoryInfo(path).Name);
//		}

//	}
//}


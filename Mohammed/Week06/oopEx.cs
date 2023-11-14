using System;
namespace Mohammed.Week06
{
	public class oopEx
	{
		private string _Name;

		public oopEx(string Name)
		{
			_Name = Name;
		}

		public static void Start()
		{
			Console.WriteLine("hello World!");
			StartPrivate();
		}

		private static void StartPrivate()
		{
			Console.WriteLine("This is a private function.");
		}

		public string GetHello()
		{
			return "Hello " + _Name + "!!!";
		}
	}


	
}


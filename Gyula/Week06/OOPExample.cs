using System;
namespace Gyula.Week06
{
	public class OOPExample
	{
		private string _Name;

		public OOPExample(string Name) {
			_Name = Name;
		}

		public static void Start()
		{
			Console.WriteLine("Hello World!");
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


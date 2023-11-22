using System;
namespace Gyula.Week07.Vererbung
{
	public class Apfel : Obst
	{
		private int _Size;
		public Apfel(string name, bool qualityOK, int size) : base(name, qualityOK)
		{
			_Size = size;
		}
		public override void PrintMe()
		{
			Console.WriteLine($"Ich bin {_Name} und ich bin MEHR als ein Obst!");
		}
	}
}


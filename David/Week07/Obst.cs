using System;
namespace David.Week07
{
	public class Obst
	{
		protected string _Name;
		private string _Color;
		private int _Price;


		public Obst(string name, string color, int price)
		{
			_Name = name;
			_Color = color;
			_Price = price;
		}

		public virtual void PrintObst()
		{
			Console.WriteLine(_Name);
		}
	}
}

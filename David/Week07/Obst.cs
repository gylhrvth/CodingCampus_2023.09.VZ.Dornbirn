using System;
namespace David.Week07
{
	public class Obst
	{
		protected string Name;
		private string Color;
		private int Price;


		public Obst(string name, string color, int price)
		{
			this.Name = name;
			this.Color = color;
			this.Price = price;
		}

		public virtual void PrintObst()
		{
			Console.WriteLine(Name);
		}
	}
}

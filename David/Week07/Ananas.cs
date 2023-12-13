using System;
namespace David.Week07
{
	public class Ananas : Obst
	{
		private string Leafs;


		public Ananas (string name, string color, int price, string leafs) : base(name, color, price)
		{
			this.Leafs = leafs;
		}

        public override void PrintObst()
        {

			base.PrintObst();
			Console.WriteLine($"My name is {Name} and I'm special because I have {Leafs} as hair!");
        }
    }
}
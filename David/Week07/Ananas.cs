using System;
namespace David.Week07
{
	public class Ananas : Obst
	{
		private string _Leafs;


		public Ananas (string name, string color, int price, string leafs) : base(name, color, price)
		{
			_Leafs = leafs;
		}

        public override void PrintObst()
        {

			base.PrintObst();
			Console.WriteLine($"My name is {_Name} and I'm special because I have {_Leafs} as hair!");
        }
    }
}
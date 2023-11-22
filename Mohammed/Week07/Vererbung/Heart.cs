using System;
namespace Mohammed.Week07.Vererbung
{
	public class Heart : Lung
	{
		private string _Name;
		private bool _Side;


        public Heart(string name, string location, bool side) : base (name, side, location)
		{

			_Name = name;
		}

		public override void PrintMe()
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"the organ{_Name} is in the right side ");

			
		}
	}
}


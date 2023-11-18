using System;
namespace Gyula.Week07.Vererbung
{
	public class BTablette : VitaminQuelle
	{
		public BTablette(string vitamin) : base(vitamin)
		{
		}

		public override void Einnahme()
		{
			Console.WriteLine($"In Wasser auflösen und trinken... von {_VitaminName}");
		}
	}
}


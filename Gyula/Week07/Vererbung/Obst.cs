using System;
namespace Gyula.Week07.Vererbung
{
	public class Obst : VitaminQuelle
	{
		protected string _Name;
		private bool _QualityOK;

		public Obst(string name, bool qualityOK) : base("Natürliches C Vitamin")
		{
			_Name = name;
			_QualityOK = qualityOK;
		}

		public virtual void PrintMe()
		{
			Console.WriteLine(_Name);
		}

        public override void Einnahme()
        {
			Console.WriteLine($"{_Name} waschen und essen.");
        }

    }
}


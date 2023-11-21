using System;
namespace Gyula.Week07.Vererbung
{
	public class Obst
	{
		protected string _Name;
		private bool _QualityOK;
		public Obst(string name, bool qualityOK)
		{
			_Name = name;
			_QualityOK = qualityOK;
		}
		public virtual void PrintMe()
		{
			Console.WriteLine(_Name);
		}
	}
}


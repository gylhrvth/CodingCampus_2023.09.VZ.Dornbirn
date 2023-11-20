using System;
namespace Gyula.Week07.Vererbung
{
	public abstract class VitaminQuelle
	{
		protected string _VitaminName;
		public VitaminQuelle(string name)
		{
			_VitaminName = name;
		}

		public abstract void Einnahme();
	}
}


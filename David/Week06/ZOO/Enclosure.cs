﻿using System;
namespace David.Week06.ZOO
{
	public class Enclosure
	{
		private string _Description;
		private string _Climate;
		private string _Name;

		public Enclosure(string name, string climate, string description)
		{
			_Description = description;
			_Climate = climate;
			_Name = name;
		}

		public void PrintEnclosure()
		{
			Console.WriteLine($"   === Name: {_Name}, Climate: {_Climate}, Description: {_Description}");
		}
	}
}


using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

namespace David.Week11.uebung
{
	public class database
	{
		private string connectionString;
		MySqlConnection connection;

		public database(string connectionString)
		{
			this.connectionString = connectionString;
		}
	}
}


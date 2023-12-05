using System;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace David.Week10
{
	public class MySQL_PreparedStatement
	{
		public static void Start()
		{
			string connectionString = "Server=localhost;port=3306;user=David;passwort=David;database=Mondial";
			MySqlConnection connection = new MySqlConnection(connectionString);
			try
			{
				connection.Open();
				MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

				command.Parameters.AddWithValue("@Name", "%on");
				command.Parameters.AddWithValue("@pop", 1000000);
				MySqlDataAdapter dataReader = command.ExecuteReader();

				PrintResult(dataReader);
				dataReader.Close();
			}
			catch (MySqlException se)
			{
				Console.WriteLine(se.Message);
			}
		}
	}
}
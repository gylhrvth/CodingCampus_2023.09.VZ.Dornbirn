using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace David.Week10
{
	public class MySQL_PreparedStatement
	{
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=david;password=david;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT l.Name, ROUND(sum(c.Population * l.Percentage / 100)) AS totalSP\n\tFROM `language` l \n\tJOIN country c on c.Code = l.Country\n\tGROUP BY l.Name\n\tORDER BY totalSP DESC LIMIT 10;", connection);

                command.Parameters.AddWithValue("@Name", "%on");
                command.Parameters.AddWithValue("@Pop", 1000000);
                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void PrintResult(MySqlDataReader dataReader)
        {
            int abst = 20;
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(header[i].ColumnName.PadRight(abst));
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }

                    if (i == 2)
                    {
                        Console.Write(dataReader[i].ToString().PadLeft(abst));
                    }
                    else
                    {
                        Console.Write(dataReader[i].ToString().PadRight(abst));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
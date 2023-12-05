using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace Niklas.Week10.MySql
{
    public class MySQL_PreparedStatement
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=Niklas;password=6C#fw,_.UDbLa&g;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

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
            string space = " | ";
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write($"{space,-5}");
                }
                Console.Write(header[i].ColumnName);
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
                    Console.Write(dataReader[i]);
                }
                Console.WriteLine();
            }
        }
    }
}

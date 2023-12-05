using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week11
{
    internal class MySQL_ConnectExample
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
                    Console.Write($"{space}");
                }
                Console.Write($"{header[i].ColumnName,-14}");
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write($"{space}");
                    }
                    Console.Write($"{dataReader[i],-14}");
                }
                Console.WriteLine();
            }
        }
    }
}
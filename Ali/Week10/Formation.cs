using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Ali.Week10
{
    public class Formation
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=Ali;password=Denizli20@;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM city WHERE Name LIKE @Name AND Population > @Pop", connection);

                command.Parameters.AddWithValue("@Name", "%");
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
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            PrintHeader(header);
            PrintHeaderSeparator(header);

            while (dataReader.Read())
            {
                PrintDataRow(dataReader);
            }
        }

        public static void PrintHeader(List<DbColumn> header)
        {
            foreach (var column in header)
            {
                Console.Write($"{column.ColumnName,-20} | ");
            }
            Console.WriteLine();
        }

        public static void PrintHeaderSeparator(List<DbColumn> header)
        {
            foreach (var column in header)
            {
                Console.Write(new string('-', 20) + " | ");
            }
            Console.WriteLine();
        }

        public static void PrintDataRow(MySqlDataReader dataReader)
        {
            for (int i = 0; i < dataReader.FieldCount; i++)
            {
                if (dataReader.GetFieldType(i) == typeof(int) || dataReader.GetFieldType(i) == typeof(double) || dataReader.GetFieldType(i) == typeof(float))
                {
                    Console.Write($"{dataReader[i],20} | ");
                }
                else
                {
                    string columnName = dataReader.GetName(i);
                    if (columnName.Equals("Longitude") || columnName.Equals("Latitude"))
                    {
                        Console.Write($"{dataReader[i],20} | ");
                    }
                    else
                    {
                        Console.Write($"{dataReader[i],-20} | ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

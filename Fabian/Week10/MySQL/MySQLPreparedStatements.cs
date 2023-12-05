﻿using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Reflection;

namespace Fabian.Week10.MySQL
{
    internal class MySQLPreparedStatements
    {
        public static void Start()
        {
            string connectionString = "server=localhost;port=3306;user=root;password=?Krfa2006?;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("select * from city where country like @Name and population > @Pop order by population desc;", connection);

                command.Parameters.AddWithValue("@Name", "%A");
                command.Parameters.AddWithValue("@Pop", 500000);
                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch(MySqlException se)
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
            for (int i = 0; i < header.Count; i++)
            {
                if(i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write($"{header[i].ColumnName, -21}");
            }
            Console.WriteLine();

            while(dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }
                    if (IsNumeric(dataReader[i]))
                    {
                        Console.Write($"{dataReader[i],21}");
                    }
                    else
                    {
                        Console.Write($"{dataReader[i],-21}");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        
        private static bool IsNumeric(object value)
        {
            return value is int || value is double || value is float || value is decimal;
        }

    }
}

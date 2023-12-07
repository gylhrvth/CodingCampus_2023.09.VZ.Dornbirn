using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riccardo.Week10
{

    internal class MSSQL_test
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Riccardo;Password=Riccardo1234";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "%on";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;
                try
                {
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    PrintResult(dataReader);
                    dataReader.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }

        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            // Calculate the total width for each column
            List<int> columnWidths = header.Select(col => col.ColumnName.Length).ToList();
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    int length = dataReader[i].ToString().Length;
                    if (length > columnWidths[i])
                    {
                        columnWidths[i] = length;
                    }
                }
            }

            // Print top border
            Console.WriteLine("+" + new string('-', columnWidths.Sum(i => i + 3) - 1) + "+");

            // Print header
            Console.Write("|");
            for (int i = 0; i < header.Count; i++)
            {
                Console.Write($" {header[i].ColumnName.PadRight(columnWidths[i])} |");
            }
            Console.WriteLine();

            // Print header and data separator
            Console.Write("+" + new string('-', columnWidths.Sum(i => i + 3) - 1) + "+");
            Console.WriteLine();

            // Print data
            while (dataReader.Read())
            {
                Console.Write("|");
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.Write($" {dataReader[i].ToString().PadRight(columnWidths[i])} |");
                }
                Console.WriteLine();
            }

            // Print bottom border
            Console.WriteLine("+" + new string('-', columnWidths.Sum(i => i + 3) - 1) + "+");
        }
        /*
        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            // Print header
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(header[i].ColumnName);
            }
            Console.WriteLine();

            // Print data
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
        */

    }

    /*
    internal class MSSQL_test
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Riccardo;Password=Riccardo1234";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select * from city where Name LIKE @Name and Population > @Pop", connection);

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 80).Value = "%on";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 1000000;
                try
                {
                    command.Connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    PrintResult(dataReader);
                    dataReader.Close();
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }


        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
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
    }c
    */
}


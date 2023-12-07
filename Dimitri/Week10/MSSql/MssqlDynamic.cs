using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Dimitri.Week10.MSSql
{
    internal class MSSqlDynamic
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=mondial;server=tcp:127.0.0.1,1433;User=dimitri;Password=sqlnew";
            string query = "SELECT * FROM country";
            int[] columnWidths;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Determine maximum column widths
                        columnWidths = GetMaxColumnWidth(reader);
                        for(int i = 0; i < columnWidths.Length; i++)
                        {
                            Console.Write($"{columnWidths[i]}, ");
                        }
                        Console.WriteLine();
                        PrintQueryTable(reader, columnWidths);
                    }
                    //using (SqlDataReader reader = command.ExecuteReader())
                    //{
                    //    PrintQueryTable(reader, columnWidths);
                    //}
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }

        public static int[] GetMaxColumnWidth(SqlDataReader reader)
        {
            int[] columnWidths = new int[reader.FieldCount];

            List<DbColumn> header = reader.GetColumnSchema().ToList();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    int lengthColumn = reader[i].ToString().Length;

                    columnWidths[i] = Math.Max(columnWidths[i], lengthColumn);
                }
            }

            for(int i = 0; i < header.Count; i++)
            {
                int lengthHeader = header[i].ColumnName.Length;

                columnWidths[i] = Math.Max(columnWidths[i], lengthHeader);
            }

            return columnWidths;

        }

        public static void PrintQueryTable(SqlDataReader reader, int[] columnWidths)
        {
            // Print headers
            List<DbColumn> header = reader.GetColumnSchema().ToList();
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                string formatstring = string.Format("{{0,{0}}}", -columnWidths[i]);
                Console.Write(formatstring, header[i].ColumnName);
            }
            Console.WriteLine();


            // Print data
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }
                    if (reader.GetDataTypeName(i).CompareTo("float") == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        string formatstring = string.Format("{{0,{0}}}", columnWidths[i]);
                        Console.Write(formatstring, reader[i]);
                    } else if (reader.GetDataTypeName(i).CompareTo("nvarchar") == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        string formatstring = string.Format("{{0,{0}}}", -columnWidths[i]);
                        Console.Write(formatstring, reader[i]);
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string formatstring = string.Format("{{0,{0}}}", columnWidths[i]);
                        Console.Write(formatstring, reader[i]);
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();

        }

    }
}

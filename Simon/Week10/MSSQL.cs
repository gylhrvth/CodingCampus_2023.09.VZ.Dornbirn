using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simon.Week10
{
    public class MSSQL
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=simber;Password=simon1234";

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
                Console.Write("| ");
                //string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                string formatString = $"{{0,{-1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length)}}} ";
                Console.Write(formatString, header[i].ColumnName);

            }
            Console.WriteLine();
            Console.ResetColor();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.Write("| ");
                    if (header[i].DataTypeName == "nvarchar")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    else if (header[i].DataTypeName == "float")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string formatString = string.Format("{{0,{0}}} ", Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }




}

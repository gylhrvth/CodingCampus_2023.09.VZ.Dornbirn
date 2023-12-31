﻿using System;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Text;
using System.ComponentModel.Design;

namespace Patrick.Week10
{
    public class MSSQL_PreparedStatement
    {
        private static ConsoleColor[] myCOLOR = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta, ConsoleColor.DarkBlue };

        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=patrick;Password=slipknot6";

            //string input = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select *\r\nfrom city\r\nwhere name like @Name AND Population > @Pop AND Elevation < @ele", connection);

                command.Parameters.Add("@Name", SqlDbType.NVarChar, 22).Value = "A%";
                //command.Parameters.Add("@Name2", SqlDbType.NVarChar, 22).Value = "%a";
                command.Parameters.Add("@Pop", SqlDbType.Int).Value = 10000;
                command.Parameters.Add("@ele", SqlDbType.Int).Value = 200;
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    PrintResult(dataReader);
                    dataReader.Close();
                }catch(SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
        }

        public static void PrintResult(SqlDataReader dataReader)
        {
            
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            
            PrintSepLine(header);
            for (int i = 0; i < header.Count; i++)
            {
                //Console.WriteLine(header[i].ColumnName + " " + header[i].DataTypeName + "[" + header[i].ColumnSize + "] ");           //zum herausfinden welche Datentypen vorhanden sind
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Red;
                string formatString = string.Format("{{0, {0}}} ", -1 * header[i].ColumnSize);
                Console.Write(formatString, header[i].ColumnName);
                Console.ResetColor();
            }
            Console.WriteLine("|");
            PrintSepLine(header);

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {                 
                    Console.Write("|");
                    Console.ForegroundColor = myCOLOR[i % myCOLOR.Length];
                    if (dataReader.GetDataTypeName(i).Equals("nvarchar"))
                    {
                        string formatString = string.Format("{{0, {0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    else if (dataReader.GetDataTypeName(i).Equals("float"))
                    {
                        string formatString = string.Format("{{0, {0}}} ", 1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    Console.ResetColor();
                }
                Console.WriteLine("|");
            }
            PrintSepLine(header);
        }

        private static void PrintSepLine(List<DbColumn> header)
        {
            for (int i = 0; i < header.Count; i++)
            {
                Console.Write("|");
                string formatString = string.Format("{{0,{0}}}", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                Console.Write(formatString, RepeatStrBuilder("-", Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length)+1));
            }
            Console.WriteLine("|");
        }

        public static string RepeatStrBuilder(string text, int n)
        {
            return new StringBuilder(text.Length * n)
              .Insert(0, text,n)
              .ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week10
{
    public class SQL_PreparedStatement
    {
        public static void Start()
        {

            Console.WriteLine("Welches Land möchten sie wissen?");
            string land = Console.ReadLine();
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=cemal;Password=cemal";
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
                    string formatString = string.Format("{{0,{0}}}", Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                    Console.Write(formatString + "|", dataReader[i]);
                }
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (header[i].DataTypeName == "float")
                    {
                        string formatString = string.Format("{{0,{0}}}|", Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString, dataReader[i]);
                    }
                    else 
                    {
                        string formatString = string.Format("{{0,{0}}}", - 1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatString + "|", dataReader[i]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

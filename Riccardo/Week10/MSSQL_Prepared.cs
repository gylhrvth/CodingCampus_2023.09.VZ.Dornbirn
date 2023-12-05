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
    internal class MSSQL_Prepared
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:192.168.188.78,1433;User=gyula;Password=gyula";

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
    }
}

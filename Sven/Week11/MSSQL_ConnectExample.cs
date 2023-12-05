using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week11
{
    internal class MSSQL_ConnectExample
    {
        public static void Start()
        {

            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:Local_Host;User=sven;Password=ihesfb2010";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand("SELECT country.Name, country.Population, country.Capital\r\nFROM Country\r\nWHERE Country.Name LIKE 'A%'");
                try
                {

                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();

                        for (int i = 0; i < header.Count; i++)
                        {
                            Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "[" + header[i].ColumnSize + "]    ");
                        }
                        Console.WriteLine();


                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {

                                Console.Write(reader[i] + " ");

                            }
                            Console.WriteLine();

                        }

                    }

                }
                catch (SqlException sqle)
                {
                    Console.WriteLine(sqle.Message);
                }

            }
        }

    }
}

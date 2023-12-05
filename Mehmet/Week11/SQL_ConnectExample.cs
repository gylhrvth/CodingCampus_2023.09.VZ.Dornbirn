using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week11
{
    internal class SQL_ConnectExample
    {
        public static void Start()
        {
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Mehmet;Password=Mehmet";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select ci.Name, ci.Province , ci.Population \r\n\tFrom City ci\r\n\tJoin Country c on c.Code = ci.Country\r\n\twhere c.Name = 'Austria'", connection);

                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();

                        foreach (DbColumn column in header)
                        {
                            Console.Write($"|{column.ColumnName,-20} | "); // 15 ist fixe breite
                        }
                        Console.WriteLine("\n|=====================| |=====================| |=====================|");


                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value = reader[i].ToString();
                                if (header[i].DataTypeName == "float")
                                {
                                    Console.Write($"|{value,20} | "); // Rechtsbündig
                                }
                                else
                                {
                                    Console.Write($"|{value,-20} | ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}

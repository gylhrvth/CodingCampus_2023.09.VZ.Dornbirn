using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week11
{
    internal class MSSQLSORT
    {


        public static void Start()
        {
            Console.Write("Welches Land möchtest du sehen? ");
            string land = Console.ReadLine();


            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=jovo;Password=jovo13696";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select c.* \nfrom City c \njoin country co on c.Country = co.Code \nwhere co.Name = @LandSelect", connection);

                command.Parameters.Add("@LandSelect", System.Data.SqlDbType.NVarChar).Value = land;
                try
                {
                    command.Connection.Open();

                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();
                        for (int i = 0; i < header.Count; i++)
                        {
                            //Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "["+ header[i].ColumnSize + "]   ");
                            if (header[i].DataTypeName == "nvarchar")
                            {
                                string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                Console.Write(formatString, header[i].ColumnName);
                            }
                            else if (header[i].DataTypeName == "float")
                            {
                                Console.Write("| {0,20:N2} ", header[i].ColumnName);
                            }
                            else
                            {
                                Console.Write("| {0,20} ", header[i].ColumnName);
                            }
                        }
                        Console.WriteLine("|");
                        Console.ResetColor();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write("| ");
                                if (header[i].DataTypeName == "nvarchar")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                    Console.Write(formatString, reader[i]);
                                }
                                else if (header[i].DataTypeName == "float")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("{0,20:N2} ", reader[i]);
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("{0,20} ", reader[i]);
                                }
                                Console.ResetColor();
                            }
                            Console.WriteLine("|");
                        }
                    }
                }
                catch (SqlException sqlE)
                {
                    Console.WriteLine(sqlE.Message);
                }
            }
        }
    }
}

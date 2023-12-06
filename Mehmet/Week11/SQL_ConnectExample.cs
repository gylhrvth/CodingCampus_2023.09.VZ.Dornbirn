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
            int b = 0;
            Console.WriteLine("Welches Land möchtest du haben?");
            string  land = Console.ReadLine();
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=Mehmet;Password=Mehmet";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand($"Select ci.Name, ci.Province , ci.Population \r\n\tFrom City ci\r\n\tJoin Country c on c.Code = ci.Country\r\n\twhere c.Name = '{land}'", connection);
                try
                {
                    command.Connection.Open();
                    Console.WriteLine("Verbindung wurde aufgebaut.");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<DbColumn> header = reader.GetColumnSchema().ToList();
                        for (int i = 0; i < header.Count; i++)
                        {
                            if (header[i].DataTypeName == "float")
                            {
                                string formatString = string.Format("{{0,{0}}} ", Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnSize));
                                Console.Write(formatString + "|", header[i].ColumnName);
                                b =b + (int)header[i].ColumnSize;
                            }
                            else
                            {
                                string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnSize));
                                Console.Write(formatString + "|", header[i].ColumnName);
                                b = b + (int)header[i].ColumnSize;
                            }
                        }
                        b = b + 8;
                        Console.WriteLine();
                        for (int i =0; i < b; i++)
                        {
                            Console.Write("=");
                        }
                        Console.WriteLine();
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string value = reader[i].ToString();
                                if (header[i].DataTypeName == "float")
                                {
                                    string formatString = string.Format("{{0,{0}}} ",  Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                    Console.Write(formatString + "|", reader[i]);
                                }
                                else
                                {
                                    string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                    Console.Write(formatString + "|", reader[i]);
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

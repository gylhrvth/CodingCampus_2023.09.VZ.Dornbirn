using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Niklas.Week11
{
    internal class idk
    {
        public static void Start()
        {
            while (true)
            {
                Console.Write("Welches Land möchtest du sehen? ");
                string land = Console.ReadLine();

                string connectionString = "port=3306;user=Niklas;password=6C#fw,_.UDbLa&g;database=Mondial;server=localhost";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand("select c.* from City c join country co on c.Country = co.Code where co.Name = @LandSelect order by population desc", connection);

                    command.Parameters.Add("@LandSelect", MySqlDbType.VarChar).Value = land;

                    try // System.Data.SqlDbType.NVarChar MySql.Data.MySqlClient.MySqlDbType
                    {
                        command.Connection.Open();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        using (MySqlDataReader reader = command.ExecuteReader())
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
                                    string formatString = string.Format("| {{0,{0}:N2}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                    Console.Write(formatString, header[i].ColumnName);
                                }
                                else
                                {
                                    string formatString = string.Format("| {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                    Console.Write(formatString, header[i].ColumnName);
                                }
                            }
                            Console.WriteLine("|");
                            Console.ResetColor();
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    Console.Write("| ");
                                    if (header[i].DataType == typeof(string))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string formatString = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                        Console.Write(formatString, reader[i]);
                                    }
                                    else if (header[i].DataType == typeof(float))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        string formatString = string.Format("{{0,{0}:N2}} ", 1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                        Console.Write(formatString, reader[i]);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        string formatString = string.Format("{{0,{0}}} ", 1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                                        Console.Write(formatString, reader[i]);
                                    }
                                    Console.ResetColor();
                                }
                                Console.WriteLine("|");
                            }
                        }
                    }
                    catch (MySqlException sqlE)
                    {
                        Console.WriteLine(sqlE.Message);
                    }
                }
            }
        }
    }
}
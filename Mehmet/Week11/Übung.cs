using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week11
{
    internal class Übung
    {
        public static void Start()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString());
            Console.Write("What you want to search for: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();


            if (userInput == "exit")
            {
                Environment.Exit(0);
            }
            else if (userInput == "clear")
            {
                Console.Clear();
                Start();
            }

            SqlCommand cmd = new SqlCommand("select Country.Name, ci.Name, Country.Code, ci.Population" +
                " from Country join city ci on ci.Country = country.Code" +
                " where Country.Name = @userInput or Country.Code = @userInput or ci.Name = @userInput", sqlConnection);

            cmd.Parameters.AddWithValue("@userInput", userInput);

            try
            {
                cmd.Connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<DbColumn> header = reader.GetColumnSchema().ToList();

                    foreach (DbColumn column in header)
                    {
                        Console.Write(column.ColumnName + "   |    ");
                    }
                    Console.WriteLine("\n");
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i] + "      |      ");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                    Start();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }


        }

        public static string ConnectionString()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=Mehmet;Password=Mehmet";
        }
    }
}

using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq.Expressions;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Gheorghe.Week10
{
    public class SqlAufgabeConnection
    {
        public static void Start()
        {
            Console.WriteLine("Welche stadt möchtest du sehen?");
            string userinput = Console.ReadLine();
            //string stadt = Console.ReadLine();
            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localhost,1433;User=gheorghe;Password=Eldad100";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("select c.Name, c.population from city c where Name = @userinput", connection);
                command.Parameters.AddWithValue("@userinput", userinput);             
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
                            //Console.Write(header[i].ColumnName + " " + header[i].DataTypeName + "["+ header[i].ColumnSize + "]  ");
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
                Console.WriteLine("Willst du die population erhöhen wenn ja = y wenn nicht = n");
                string userinput2 = Console.ReadLine();
                if(userinput2 == "y")
                {

                }
            }
        }
    }
}
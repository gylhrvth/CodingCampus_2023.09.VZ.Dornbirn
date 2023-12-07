using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week11.MSSQL_ConnectCity
{
    internal class MSSQL_ConnectCity
    {
        public static void Start()
        {
            Console.Write("Welche Stadt soll bearbeitet werden? ");
            string city = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine("Ungültige Stadt. Bitte eine gültige Stadt eingeben.");
                return;
            }

            string connectionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:LocalHost,1433;User=sven;Password=ihesfb2010";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Verbindung wurde aufgebaut.");


                    using (SqlCommand selectcmd = new SqlCommand("SELECT City.Name, Population FROM City WHERE City.Name = @CitySelect", connection))
                    {
                        selectcmd.Parameters.AddWithValue("@CitySelect", city);

                        using (SqlDataReader reader = selectcmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine($"| {reader["Name"],-10} | {reader["Population"],-10} |");
                            }
                        }
                    }

                    Console.Write("Wie viele Bewohner sollen Hinzugefügt werden? ");
                    if (int.TryParse(Console.ReadLine(), out int popadd))
                    {

                        using (SqlCommand updatecmd = new SqlCommand("UPDATE City SET population = population + @Popadd WHERE City.name = @CitySelect", connection))
                        {
                            updatecmd.Parameters.AddWithValue("@Popadd", popadd);
                            updatecmd.Parameters.AddWithValue("@CitySelect", city);

                            int rowsAffected = updatecmd.ExecuteNonQuery();

                            Console.WriteLine($"{rowsAffected} geänderte Daten");

                            if (rowsAffected > 0)
                            {
                                using (SqlCommand afterUpdateCmd = new SqlCommand("SELECT City.Name, Population FROM City WHERE City.Name = @CitySelect", connection))
                                {
                                    afterUpdateCmd.Parameters.AddWithValue("@CitySelect", city);

                                    using (SqlDataReader reader = afterUpdateCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            Console.WriteLine($"| {reader["Name"],-10} | {reader["Population"],-10} |");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bitte gib eine gültige Zahl ein!");
                            }
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

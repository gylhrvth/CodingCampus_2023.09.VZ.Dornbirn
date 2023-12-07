using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week11
{
    internal class Aufgabe1
    {
        public static void Start()
        {
            SqlConnection connection = new SqlConnection(StringConnect());
            Console.WriteLine("Geben Sie eine Stadt ein: ");

            string cityName = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("SELECT ci.Province, ci.Name, ci.Population " +
                "FROM City ci " +
                "WHERE ci.Name = @cityName", connection);
            cmd.Parameters.AddWithValue("@cityName", cityName);

            try
            {
                connection.Open();
                Console.WriteLine("connection is succeed!!\n\n\n");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int p = 0;
                    List<DbColumn> header = reader.GetColumnSchema().ToList();

                    while (reader.Read())
                    {
                        foreach (DbColumn col in header)
                        {
                            Console.Write(col.ColumnName + "     |     ");
                        }
                        Console.WriteLine();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader[i] + "   -   ");
                        }
                        Console.WriteLine("\n");
                        p++;
                    }

                    if (p == 1)
                    {
                        if(AskForPopulationChange(cityName))
                        {
                            ChangePopulation(cityName);
                        } else
                        {
                            Start();
                        }
                    } else if(p == 0)
                    {
                        Console.WriteLine("Versuchs Nochmal!");
                        Start();
                    }
                    else
                    {
                        Console.WriteLine("Stadt ist nicht eindeutig!");
                        Start();
                    }
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex);
            } finally
            {
                connection.Close();
            }
        }

        public static int TypeNumber()
        {
            while (true)
            {
                try
                {
                    string Input = Console.ReadLine();
                    int newInput = Convert.ToInt32(Input);
                    return newInput;
                }
                catch
                {
                    Console.WriteLine("Hust -Zahl- Hust");
                }
            }
        }
        public static bool AskForPopulationChange(string cityName)
        {
            Console.WriteLine("Wollen Sie die Population ändern? ja | nein");
            string myWill = Console.ReadLine().Trim().ToLower();

            if (myWill == "nein")
            {
                return false;
            } 
            else if (myWill == "ja")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Versuch es nochmal");
                return AskForPopulationChange(cityName);
            }
        }
        public static string StringConnect()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=Mehmet;Password=Mehmet";
        }
        public static void ChangePopulation(string cityName)
        {
            string connectionString = (StringConnect());
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("connection is succeed!!\n\n\n");
                Console.WriteLine("um wie viel soll es sich ändern? (±x)");
                int number = TypeNumber();
                string query = "update City set Population = Population + @number\r\n\tWhere Name = @cityName";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@cityName", cityName);
                    command.ExecuteNonQuery();
                    {
                        conn.Close();
                        Console.WriteLine("connection is closed!!");
                    }
                }
            }
        }
    }
}

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

            string Input1 = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("Select ci.Province , ci.Name,  ci.Population \r\n\tFrom City ci\r\n\twhere ci.Name = @Input1", connection);
            cmd.Parameters.AddWithValue("Input1", Input1);

            try
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int p = 0;
                    List<DbColumn> header = reader.GetColumnSchema().ToList();

                    while (reader.Read())
                    {
                        Console.WriteLine("connection is succeed!!\n\n\n");
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
                        NochmalAbfrage(Input1);
                    }
                    if (p == 0 ) 
                    {
                        Console.WriteLine("Versuchs Nochmal!");
                        Start();
                    }
                    Start();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
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
        public static void NochmalAbfrage(string Input1)
        {
            Console.WriteLine("Wollen Sie die Population ändern? ja | nein");
            string Input2 = Console.ReadLine();

            if (Input2 == "nein")
            {
                Start();
            }
            if (Input2 == "ja")
            {
                ChangePopulation(Input1);
            }
            else
            {
                Console.WriteLine("Versuch es nochmal");
                NochmalAbfrage(Input1);
            }
        }
        public static string StringConnect()
        {
            return "Persist Security Info=False;Initial Catalog=Mondial;server=tcp: localhost,1433;User=Mehmet;Password=Mehmet";
        }
        public static void ChangePopulation(string Input1)
        {
            string connectionString = (StringConnect());
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("(Verbindung erfolgreich)\n\n\n");
                Console.WriteLine("um wie viel soll es sich ändern? (±x)");
                int Input2 = TypeNumber();
                string query = "update City set Population = Population + @Input2\r\n\tWhere Name = @Input1";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Input2", Input2);
                    command.Parameters.AddWithValue("@Input1", Input1);
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

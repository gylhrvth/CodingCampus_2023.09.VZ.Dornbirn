using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Martin.Week10
{
    public class MySql
    {
        public static void Start()
        {
            //Der ConnectionString(Object) ruft durch den "ConnectionString" (Server...) eine Verbindung zum MySql server auf.
            //Der String enthält den USER und das pwd ,die Datenbank und den Port und server
            string connectionString = "server=localhost;port=3306;user=Martin;password=NiceTry;database=Mondial";
            MySqlConnection connection = new MySqlConnection(connectionString);
            //MySqlConnection: ist das NugetPaket das wir verwenden um eine Verbindung aufzubauen
            //Die Klasse stellt eine reihe von Methoden und eigenschaften breit

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            
            try
            {
                connection.Open();
                Console.WriteLine("Verbindung wurde aufgebaut.");
                //Jedes mal wenn man einen command erstellt muss man davor die Verbindung mit .Open() erstellen

                MySqlCommand command = new MySqlCommand("select * from city where Country LIKE @Name and Population > @Pop", connection);
                //Der command wird mit connection hinesendet

                command.Parameters.AddWithValue("@Name", "A");
                command.Parameters.AddWithValue("@Pop", 1000);
                //@Name bezieht sich auf %on und sucht dann alle Länder die mit on enden
                //@Pop ist 1000

                MySqlDataReader dataReader = command.ExecuteReader();
                //führt mein command aus

                PrintResult(dataReader);
                //wir zeigen den dataReader in der Console an.

                dataReader.Close();
                //die verbindung schliessen
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close(); //schliest die verbindung
            }
        }


        public static void PrintResult(MySqlDataReader dataReader)
        {

            List<DbColumn> header = dataReader.GetColumnSchema().ToList();
            // nimm die columns z.B hat City und hat Country,Name..usw und macht dann eine liste daraus

            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write($"|");
                }
                string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                Console.Write(formatstring, header[i].ColumnName);
            }
            Console.WriteLine("|");


            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write("|");
                    }
                
                    if (dataReader.GetDataTypeName(i) == "VARCHAR")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string formatstring = string.Format("{{0, {0}}}", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string formatstring = string.Format("{{0, {0}}}", +1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        Console.Write(formatstring, dataReader[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("|");
            }
        }


    }
}

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Selina.Week10.Aufgabe_02
{
    public class User
    {
        public static ConsoleColor[] colors = new ConsoleColor[] { ConsoleColor.Cyan, ConsoleColor.Magenta, ConsoleColor.DarkBlue, ConsoleColor.Blue, ConsoleColor.DarkMagenta, ConsoleColor.Blue, ConsoleColor.Cyan };
        public static void Start()
        {
            string morePopulation;
            string again;
            do
            {
                string connenctionString = "Persist Security Info=False;Initial Catalog=Mondial;server=tcp:localHost,1433;user=selina;password=selina";

                using (SqlConnection conn = new SqlConnection(connenctionString))   //Erstellt eine SqlConnection und verwendet sie innerhalb des angegebenen Codeblocks.
                {
                    conn.Open();  //Die Zeile öffnet eine Datenbankverbindung in C# mithilfe eines SqlCommand-Objekts.
                    SqlCommand cmd = new SqlCommand("select Name as CityName, Country as Land , Province as Hauptstadt , Population as Einwohner \nfrom city where \nName like @Name", conn);    //Die Zeile erstellt ein SqlCommand-Objekt für eine SQL-Abfrage, die Städte nach Name und Bevölkerung filtert.
                    string cityName = ReadText("Bitte gib einen CityName ein: ", "Das ist kein Text, bitte versuche es erneut! ");
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = cityName; //Setzt den Parameter "@Name" auf den Wert cityName

                    if (CityIsInTheQuery(cmd))
                    {
                        morePopulation = ReadText("Möchtest du Einwohnerzahl erhöhen? (Y/N) ", "Das ist kein Text, verusche es nochmal! ");
                        if (morePopulation.ToLower() == "y")
                        {
                            float population = ReadPopulation("Wie viel Einwohner möchtest du hinzufügen? ", "Das ist keine Zahl, versuche es nochmal! ");
                            string updateQuery = $"Update City Set Population = {population} + Population  Where Name = '{cityName}'";
                            UpdatePopulation(updateQuery, conn);
                        }

                        try
                        {
                            SqlDataReader dataReader = cmd.ExecuteReader();     //Die Zeile liest die Ergebnisse einer SQL - Abfrage mit einem SqlDataReader - Objekt(dataReader).
                            PrintResult(dataReader);
                            dataReader.Close();     //Die Zeile schließt den SqlDataReader (dataReader).
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Diese Stadt gibt es nicht!");
                    }
                }

                again = ReadText("\nMöchtest du nochmal etwas ändern? (Y/N) ", "Das ist kein Text! VERSUCHE ES NOCHMAL! ");

            } while (again.ToLower() == "y");

        }
        public static void UpdatePopulation(string updateQuery, SqlConnection connection)
        {
            using(SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public static bool CityIsInTheQuery(SqlCommand cmd)
        {
            bool cityExists = false;
            try
            {
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    cityExists = true;
                }

                dataReader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cityExists;
        }
        public static float ReadPopulation(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    float number= Convert.ToSingle(Console.ReadLine());
                    return number;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
        public static string ReadText(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    string cityName = Convert.ToString(Console.ReadLine());
                    cityName.ToUpper();

                    return cityName;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
        public static void PrintResult(SqlDataReader dataReader)
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();  //Erzeugt eine Liste namens "header" aus den Spaltenschemata einer Datenbankabfrage (dataReader).

            // dynamisch: 
            for (int i = 0; i < header.Count; i++) // gibt alle Überschrieften aus
            {
                Console.ForegroundColor = colors[i % colors.Length]; // ändert Farbe

                if (header[i].DataTypeName == "nvarchar")
                {
                    string format = string.Format(" {{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));      //Die Zeile erstellt ein Formatierungsmuster für eine Spaltenausgabe basierend auf der
                                                                                                                                                   //Breite der Spalte und deren Namen.
                    Console.Write(format, header[i].ColumnName);
                }
                else if (header[i].DataTypeName == "float")
                {
                    Console.Write("  {0,20:N2} ", header[i].ColumnName);
                }
                else
                {
                    Console.Write("  {0,20:N2} ", header[i].ColumnName);
                }
            }
            Console.WriteLine();
            Console.ResetColor(); // löscht Farbe

            while (dataReader.Read()) // gibt den Text von allen Überschriften aus
            {
                // dynamisch: => Felder werden ausgerechnet aus Datenbank
                for (var i = 0; i < dataReader.FieldCount; i++)
                {
                    Console.ForegroundColor = colors[i % colors.Length];
                    Console.Write("|");

                    if (header[i].DataTypeName == "nvarchar") // wenn datentyp nvarchar
                    {
                        string format = string.Format("{{0,{0}}} ", -1 * Math.Max((int)header[i].ColumnSize, (int)header[i].ColumnName.Length));
                        // string.Format wird verwendet, wenn zwei Werte dynamisch sind!
                        // Math.Max bekommt den größten Wert von einer Spale

                        Console.Write(format, dataReader[i]); // schreibt in die Console
                    }
                    else if (header[i].DataTypeName == "float") // wenn datentyp float
                    {
                        Console.Write("{0,20:N2} ", dataReader[i]);
                    }
                    else // alles andere
                    {
                        Console.Write("{0,20:N2} ", dataReader[i]);
                    }
                    Console.ResetColor(); // löscht Farbe
                }
                Console.WriteLine("|");
            }
        }
    }
}

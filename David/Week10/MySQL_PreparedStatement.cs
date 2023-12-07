using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace David.Week10
{
    public class MySQL_PreparedStatement
    {
        public static void Start()
        {
            // Der Connection String (Object) ruft durch den "Connection String" (server=...) eine Verbindung zum MySQL server auf!
            // Der String enthält den USER und das PASSWORT, die DATENBANK und den PORT und SERVER.
            // (Statt passwort kann man auch "Pwd" verwenden.)
            string connectionString = "server=localhost;port=3306;user=david;password=david;database=Mondial"; //Praktisch die Adresse die die Erweiterung braucht.
            MySqlConnection connection = new MySqlConnection(connectionString); //Hier wird die vorher installierte ERWEITERUNG verwendet.
            // MySql 
            // MySqlConnection: Alle Interaktionen zwischen der .NET-Anwendung und dem MySQL-Server werden durch dieses Connection-Object geleitet.
            // Dies geschieht unter Verwendung des klassischen MySQL-Protokolls. Das Funktioniert nur wenn vorher der ConnectionString aufgerufen wird.
            try
            {
                connection.Open(); // HIER wird die Verbindung geöffnent!
                MySqlCommand command = new MySqlCommand("SELECT l.Name, ROUND(sum(c.Population * l.Percentage / 100)) AS totalSP\n\tFROM `language` l " +
                    "\n\tJOIN country c on c.Code = l.Country\n\tGROUP BY l.Name\n\tORDER BY totalSP DESC LIMIT 10;", connection);
                // MySqlCommand: Die Klasse wird verwendet um SQL Anweisungen an eine MySql Datenbank zu senden. SIEHE, "connecteion" am Ende der QUERY.
                // Lokale Variable "command". Kann natürlich auch einen anderen Namen erhalten.
                // OPEN und CLOSE sind wichtig um den Kanal zu öffnen und zu schließen. (Türe öffnen und hinter dir wieder schließen! ;)

                command.Parameters.AddWithValue("@Name", "%on"); //Werte für den Command @=Aufruf verhält sich wie eine "Variable", nach Komma steht dann die Bedingung zB. Endung mit "on".
                command.Parameters.AddWithValue("@Pop", 1000000);
                MySqlDataReader dataReader = command.ExecuteReader(); // ÖFFNET SICH SELBST! Führt die QUERY aus / SCHICKT sie and die Erweiterung und über diese wird die Abfrage über die DB ausgeführt.
                // Executer = Ausführer

                PrintResult(dataReader); // Führt die PRINTRESULT Methode aus
                dataReader.Close(); // SCHLIESST den EXECUTEREADER wieder 
            }
            catch (MySqlException se) // Catch falls etwas mit der Abfrage nicht funktioniert, damit es nicht abstürzt!
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close(); // HIER wird die Verbindung geschlossen!
            }
        }

        public static void PrintResult(MySqlDataReader dataReader) //PRINT METHODE --> im MySQL_connectExample.cs anschauen.
        {
            List<DbColumn> header = dataReader.GetColumnSchema().ToList(); // Header geht in die DB und liest die HEADER (SpaltenNamen) aus. So wie beim Files auslesen.
            //GetColumSchema() ist eine vorgefertigte Methode von der Erweiterung.
            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write("|");
                }
                int width = Math.Max(12, header[i].ColumnName.Length);
                if (header[i].DataType.Name == "String" && header[i].ColumnSize != null)
                {
                    width = -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                }
                string formatstring = string.Format("{{0,{0}}}", width);
                Console.Write(formatstring, header[i].ColumnName);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            while (dataReader.Read())// dataReader ist wie die Varibale vom oben angeführten MySqlDataReader -- Liest den Inhalt der DB-Tabellen.
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("|");
                    }
                    int width = Math.Max(12, header[i].ColumnName.Length);
                    string formatString = string.Format("{{0,{0}}}", width);
                    if (header[i].DataType.Name == "String" && header[i].ColumnSize != null)
                    {
                        width = -1 * Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                        formatString = string.Format("{{0,{0}}}", width);
                    }
                    else if (header[i].DataType.Name == "Single")
                    {
                        width = Math.Max((int)header[i].ColumnSize, header[i].ColumnName.Length);
                        formatString = string.Format("{{0,{0}:N2}}", width);
                    }
                    Console.Write(formatString, dataReader[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
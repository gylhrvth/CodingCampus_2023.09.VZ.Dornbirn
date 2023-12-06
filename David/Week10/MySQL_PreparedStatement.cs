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

                command.Parameters.AddWithValue("@Name", "%au"); //Werte für den Command @=Aufruf verhält sich wie eine "Variable", nach Komma steht dann die Bedingung zB. Endung mit "on".
                command.Parameters.AddWithValue("@Pop", 1000000);
                MySqlDataReader dataReader = command.ExecuteReader();

                PrintResult(dataReader);
                dataReader.Close();
            }
            catch (MySqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                connection.Close(); // HIER wird die Verbindung geschlossen!
            }
        }
        
        public static void PrintResult(MySqlDataReader dataReader)
        {
            int abst = 20;
            List<DbColumn> header = dataReader.GetColumnSchema().ToList();

            for (int i = 0; i < header.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(" | ");
                }
                Console.Write(header[i].ColumnName.PadRight(abst));
            }
            Console.WriteLine();

            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    if (i > 0)
                    {
                        Console.Write(" | ");
                    }
                    if (i == 2)
                    {
                        Console.Write(dataReader[i].ToString().PadLeft(abst));
                    }
                    else
                    {
                        Console.Write(dataReader[i].ToString().PadRight(abst));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
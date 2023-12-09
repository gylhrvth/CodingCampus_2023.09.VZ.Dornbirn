using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week10.CRUD
{
    internal class Database
    {
        private string _ConnectionString;
        private SqlConnection? _Connection;

        public Database(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public void Connect()
        {
            Disconnect();
            _Connection = new SqlConnection(_ConnectionString);
            _Connection.Open();

        }

        public void Disconnect()
        {
            _Connection?.Close();
        }
    }
}

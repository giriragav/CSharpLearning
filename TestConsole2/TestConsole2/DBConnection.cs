using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    public abstract class DBConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DBConnection(string connString)
        {
            if (string.IsNullOrEmpty(connString))
                throw new ArgumentNullException("Connection string cannot be null or empty");

            this.ConnectionString = connString;
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}

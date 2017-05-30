using System;

namespace TestConsole2
{
    public class SQLConnection:DBConnection
    {
        public SQLConnection(string connString)
            :base(connString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Making SQL Server connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Server connection");
        }
    }
}

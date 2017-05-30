using System;

namespace TestConsole2
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connString)
            : base(connString)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Making Oracle connection");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle connection");
        }
    }
}

using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ApiTeste.Data
{
    public class Banco
    {
        private readonly string _connectionString;

        public Banco(string connectionString)
        {
            _connectionString = connectionString;
        }

        //public Connection GetConnection()
        //{
        //    return new Connection(_connectionString);
        //}
    }
}

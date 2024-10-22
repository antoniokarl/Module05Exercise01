using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Module07DataAccess.Services
{
    public class DatabaseConnectionService
    {
        private readonly string _connectionString;

        public DatabaseConnectionService()
        {

            _connectionString = "Server=localhost;Database=CompanyDB;User ID=employeeuser;Password=employeeuser";
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
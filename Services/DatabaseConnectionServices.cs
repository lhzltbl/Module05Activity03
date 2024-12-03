using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Exercise01.Services
{
    public class DatabaseConnectionServices
    {
        private readonly string _connectionString;

        public DatabaseConnectionServices()
        {
            _connectionString = "Server=localhost;Database=companydb;User ID=testuser;Password=testuser";
        }

        public string GetConnectionString()
        {
            return
                _connectionString;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AcademicSystem
{
    public class Database
    {
        private string connectionString = "server=localhost;database=academic_system;user=root;password=yourpassword";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

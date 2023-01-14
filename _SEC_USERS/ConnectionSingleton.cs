using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _SEC_USERS
{
    public class ConnectionSingleton
    {
        private static SqlConnection m_connection = null;
        private string m_connectionString;

        private ConnectionSingleton()
        {
            string nameConnectionString = "SECURITY_USERS.Properties.Settings.clinic10ConnectionString";
            m_connectionString = ConfigurationManager.ConnectionStrings[nameConnectionString].ConnectionString;
            m_connection = new SqlConnection("Server=.; Database=clinic10; Trusted_Connection=True");
        }

        ~ConnectionSingleton()
        {
            m_connection.Close();
            m_connection.Dispose();
        }

        public static SqlConnection getInstance()
        {
            if (m_connection == null)
            {
                m_connection = new SqlConnection("Server=.; Database=clinic10; Trusted_Connection=True");
            }
            return m_connection;
        }
    }
}

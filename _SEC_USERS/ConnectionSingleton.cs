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
        private static SqlConnection m_connection;

        private ConnectionSingleton()
        {
            m_connection = new SqlConnection(GetTestClinic10ConnectionString());
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
                new ConnectionSingleton();
            }
            return m_connection;
        }

        private string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            {
                return settings.ConnectionString;
            }
            return returnValue;
        }
        
        private string GetTestClinic10ConnectionString()
        {
            return GetConnectionStringByName("TEST_clinic10ConnectionString");
        }

        private string GetClinic10ConnectionString()
        {
            return GetConnectionStringByName("clinic10ConnectionString");
        }
    }
}

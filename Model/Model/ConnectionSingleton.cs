using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Model
{
    public class ConnectionSingleton
    {
        private static SqlConnection m_connection = new SqlConnection(GetTestClinic10ConnectionString());

        public static SqlConnection getInstance()
        {
            return m_connection;
        }

        private static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            {
                return settings.ConnectionString;
            }
            return returnValue;
        }

        private static string GetTestClinic10ConnectionString()
        {
            return GetConnectionStringByName("TEST_clinic10ConnectionString");
        }

        private static string GetClinic10ConnectionString()
        {
            return GetConnectionStringByName("clinic10ConnectionString");
        }
    }
}

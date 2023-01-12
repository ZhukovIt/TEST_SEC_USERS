using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace SECURITY_USERS
{
    public class ConnectionSingleton
    {
        private static SqlConnection m_connection = null;
        private string m_connectionString;

        private ConnectionSingleton()
        {
            string nameConnectionString = "SECURITY_USERS_GUI.Properties.Settings.clinic10ConnectionString";
            //m_connectionString = ConfigurationManager.ConnectionStrings[nameConnectionString].ConnectionString;
            m_connection = new SqlConnection(@"Data Source=SM-SERV01\SQL10_5_SIMPLEX;Initial Catalog=clinic10;User ID=sa;Password=Q12werty");
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
                m_connection = new SqlConnection(@"Data Source=SM-SERV01\SQL10_5_SIMPLEX;Initial Catalog=clinic10;User ID=sa;Password=Q12werty");
            }
            return m_connection;
        }
    }
}

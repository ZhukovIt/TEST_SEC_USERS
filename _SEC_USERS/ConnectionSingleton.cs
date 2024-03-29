﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _SEC_USERS
{
    public static class ConnectionSingleton
    {
        private static SqlConnection m_connection = new SqlConnection(GetClinic10ConnectionString());

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

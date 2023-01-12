using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SECURITY_USERS.dtsSEC_USERSTableAdapters;

namespace SECURITY_USERS
{
    public class FillDB
    {
        private dtsSEC_USERS m_dtsSEC_USERS;

        public FillDB()
        {
            m_dtsSEC_USERS = new dtsSEC_USERS();
        }

        public void LoadData()
        {
            SEC_USERTableAdapter ta_SEC_USER = new SEC_USERTableAdapter();
            ta_SEC_USER.Connection = ConnectionSingleton.getInstance();
            SEC_ROLETableAdapter ta_SEC_ROLE = new SEC_ROLETableAdapter();
            ta_SEC_ROLE.Connection = ConnectionSingleton.getInstance();
            SEC_USER_ROLETableAdapter ta_SEC_USER_ROLE = new SEC_USER_ROLETableAdapter();
            ta_SEC_USER_ROLE.Connection = ConnectionSingleton.getInstance();
            SEC_USER_TYPETableAdapter ta_USER_TYPE = new SEC_USER_TYPETableAdapter();
            ta_USER_TYPE.Connection = ConnectionSingleton.getInstance();


            m_dtsSEC_USERS.SEC_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER.Clear();
            m_dtsSEC_USERS.SEC_USER_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER_TYPE.Clear();


            ta_SEC_ROLE.Fill(m_dtsSEC_USERS.SEC_ROLE);
            ta_SEC_USER.Fill(m_dtsSEC_USERS.SEC_USER);
            ta_SEC_USER_ROLE.Fill(m_dtsSEC_USERS.SEC_USER_ROLE);
            ta_USER_TYPE.Fill(m_dtsSEC_USERS.SEC_USER_TYPE);
        }
    }
}

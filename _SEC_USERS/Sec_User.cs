﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _SEC_USERS
{
    public class Sec_User
    {
        private dtsSEC_USERS m_dts_SEC_USERS;
        private dtsSEC_USERS.SEC_USERRow m_SecUserRow;

        public Sec_User(dtsSEC_USERS dts_SEC_USERS)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
            if (m_dts_SEC_USERS.SEC_USER.Rows.Count > 0)
                m_SecUserRow = (dtsSEC_USERS.SEC_USERRow)m_dts_SEC_USERS.SEC_USER.Rows[0];
        }

        public DataView Create_SEC_USER()
        {
            return new DataView(m_dts_SEC_USERS.SEC_USER);
        }

        public DataView Create_SEC_ROLE()
        {
            return new DataView(m_dts_SEC_USERS.SEC_ROLE);
        }

        public DataView Create_SEC_USER_ROLE()
        {
            return new DataView(m_dts_SEC_USERS.SEC_USER_ROLE);
        }

        public DataView Create_SEC_USER_TYPE()
        {
            return new DataView(m_dts_SEC_USERS.SEC_USER_TYPE);
        }

        
    }
}
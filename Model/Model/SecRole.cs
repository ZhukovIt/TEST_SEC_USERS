using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SecRole
    {
        private dtsSecUsers m_dts_SEC_USERS;
        private dtsSecUsers.SEC_ROLERow m_SEC_ROLE_Row;

        public SecRole(dtsSecUsers dts_SEC_USERS)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
            if (dts_SEC_USERS.SEC_ROLE.Rows.Count > 0)
            {
                m_SEC_ROLE_Row = (dtsSecUsers.SEC_ROLERow)dts_SEC_USERS.SEC_ROLE.Rows[0];
            }
        }

        public SecRole(dtsSecUsers dts_SEC_USERS, int newRoleId)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
            if (dts_SEC_USERS.SEC_ROLE.Rows.Count > 0)
            {
                m_SEC_ROLE_Row = (dtsSecUsers.SEC_ROLERow)dts_SEC_USERS.SEC_ROLE.Rows[0];
            }
            m_SEC_ROLE_Row.SEC_ROLE_ID = newRoleId;
        }

        public int RoleId
        {
            get
            {
                return m_SEC_ROLE_Row.SEC_ROLE_ID;
            }
        }

        public string RoleName
        {
            get
            {
                return m_SEC_ROLE_Row.SEC_ROLE_NAME;
            }
        }

        public bool RoleBuiltIn
        {
            get
            {
                return m_SEC_ROLE_Row.SEC_ROLE_BUILTIN;
            }
        }

        public DataView Create_SEC_ROLE_DataView()
        {
            return new DataView(m_dts_SEC_USERS.SEC_ROLE);
        }
    }
}

using Model.dtsSecUsersTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkerDBRole
    {
        private SEC_ROLETableAdapter m_ta_SEC_ROLE;
        private static dtsSecUsers m_dts_SEC_USERS = new dtsSecUsers();

        public SEC_ROLETableAdapter TA_SEC_ROLE
        {
            get
            {
                if (m_ta_SEC_ROLE == null)
                {
                    m_ta_SEC_ROLE = new SEC_ROLETableAdapter();
                    m_ta_SEC_ROLE.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_SEC_ROLE;
            }
        }

        public dtsSecUsers Get_dts_SEC_USERS
        {
            get
            {
                return m_dts_SEC_USERS;
            }
        }

        public void LoadData()
        {
            LoadData(m_dts_SEC_USERS);
        }

        public void LoadData(dtsSecUsers dts_SEC_USERS)
        {
            dts_SEC_USERS.SEC_ROLE.Clear();

            TA_SEC_ROLE.Fill(dts_SEC_USERS.SEC_ROLE);
        }

        public SecRole CreateSecRole()
        {
            return null;
        }

        public DataView Create_SEC_ROLE_DataView()
        {
            return new DataView(m_dts_SEC_USERS.SEC_ROLE);
        }
    }
}

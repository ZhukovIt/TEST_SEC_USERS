using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _SEC_USERS
{
    public class Sec_User
    {
        private dtsSEC_USERS m_dts_SEC_USERS;
        private WorkerDB m_WorkerDB;
        private dtsSEC_USERS.SEC_USERRow m_SecUserRow;

        public Sec_User(dtsSEC_USERS dts_SEC_USERS)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
            if (m_dts_SEC_USERS.SEC_USER.Rows.Count > 0)
            {
                m_SecUserRow = (dtsSEC_USERS.SEC_USERRow)m_dts_SEC_USERS.SEC_USER.Rows[0];
            }
        }

        public Sec_User(dtsSEC_USERS dts_SEC_USERS, int newUserId) : this(dts_SEC_USERS)
        {
            m_SecUserRow.SEC_USER_ID = newUserId;
            foreach (dtsSEC_USERS.SEC_USER_ROLERow row in m_dts_SEC_USERS.SEC_USER_ROLE.Rows)
            {
                row.SEC_USER_ID = newUserId;
            }
        }

        public Sec_User(dtsSEC_USERS dts_SEC_USERS, dtsSEC_USERS.SEC_USERRow secUserRow)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
            m_SecUserRow = secUserRow;
        }

        public dtsSEC_USERS User_dts_SEC_USERS
        {
            get
            {
                return m_dts_SEC_USERS;
            }
        }

        public void SetWorkerDB(WorkerDB workerDB)
        {
            m_WorkerDB = workerDB;
        }

        public void UpdateUserSecRow()
        {
            if (m_dts_SEC_USERS.SEC_USER.Rows.Count > 0)
            {
                m_SecUserRow = (dtsSEC_USERS.SEC_USERRow)m_dts_SEC_USERS.SEC_USER.Rows[0];
            }
        }

        public int UserId
        {
            get
            {
                return m_SecUserRow.SEC_USER_ID;
            }

            set
            {
                m_SecUserRow.SEC_USER_ID = value;
            }
        }

        public string UserLogin
        {
            get
            {
                return m_SecUserRow.SEC_USER_LOGIN;
            }
        }

        public string UserFIO
        {
            get
            {
                return m_SecUserRow.SEC_USER_FIO;
            }
        }

        public bool BuiltIn
        {
            get
            {
                return m_SecUserRow.SEC_USER_BUILTIN;
            }
        }

        public bool IsDisabled
        {
            get
            {
                return m_SecUserRow.SEC_USER_DISABLED;
            }
        }

        public bool NoCheck
        {
            get
            {
                return m_SecUserRow.SEC_USER_NO_CHECK;
            }
        }

        public int TypeId
        {
            get
            {
                return m_SecUserRow.SEC_USER_TYPE_ID;
            }
        }

        public int? WorkId
        {
            get
            {
                return m_SecUserRow.WORK_ID;
            }
        }

        public string KKM_LOGIN
        {
            get
            {
                return m_SecUserRow.SEC_USER_KKM_LOGIN;
            }
        }

        public string KKM_PASSWORD
        {
            get
            {
                return m_SecUserRow.SEC_USER_KKM_PASSWORD;
            }
        }

        public string KKM_INN
        {
            get
            {
                return m_SecUserRow.SEC_USER_KKM_INN;
            }
        }

        public DataView Create_SEC_USER_DataView()
        {
            return new DataView(m_dts_SEC_USERS.SEC_USER);
        }

        public DataView Create_SEC_USER_ROLE_DataView()
        {
            return new DataView(m_dts_SEC_USERS.SEC_USER_ROLE);
        }

        public void Save()
        {
            dtsSEC_USERSTableAdapters.SEC_USERTableAdapter ta_SEC_USER = new dtsSEC_USERSTableAdapters.SEC_USERTableAdapter();
            ta_SEC_USER.Connection = ConnectionSingleton.getInstance();

            dtsSEC_USERSTableAdapters.SEC_USER_ROLETableAdapter ta_SEC_USER_ROLE = new dtsSEC_USERSTableAdapters.SEC_USER_ROLETableAdapter();
            ta_SEC_USER_ROLE.Connection = ConnectionSingleton.getInstance();


            ta_SEC_USER.Update(m_dts_SEC_USERS.SEC_USER);
            ta_SEC_USER_ROLE.Update(m_dts_SEC_USERS.SEC_USER_ROLE);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _SEC_USERS;
using _SEC_USERS.dtsSEC_USERSTableAdapters;

namespace _SEC_USERS
{
    public sealed class WorkerDB
    {
        private dtsSEC_USERS m_dtsSEC_USERS;
        private SEC_USERTableAdapter m_ta_SEC_USER;
        private SEC_ROLETableAdapter m_ta_SEC_ROLE;
        private SEC_USER_ROLETableAdapter m_ta_SEC_USER_ROLE;
        private SEC_USER_TYPETableAdapter m_ta_SEC_USER_TYPE;

        public SEC_USERTableAdapter TA_SEC_USER
        {
            get
            {
                if (m_ta_SEC_USER == null)
                {
                    m_ta_SEC_USER = new SEC_USERTableAdapter();
                    m_ta_SEC_USER.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_SEC_USER;
            }
        }

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

        public SEC_USER_ROLETableAdapter TA_SEC_USER_ROLE
        {
            get
            {
                if (m_ta_SEC_USER_ROLE == null)
                {
                    m_ta_SEC_USER_ROLE = new SEC_USER_ROLETableAdapter();
                    m_ta_SEC_USER_ROLE.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_SEC_USER_ROLE;
            }
        }

        public SEC_USER_TYPETableAdapter TA_SEC_USER_TYPE
        {
            get
            {
                if (m_ta_SEC_USER_TYPE == null)
                {
                    m_ta_SEC_USER_TYPE = new SEC_USER_TYPETableAdapter();
                    m_ta_SEC_USER_TYPE.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_SEC_USER_TYPE;
            }
        }

        public WorkerDB(dtsSEC_USERS dts_SEC_USERS)
        {
            m_dtsSEC_USERS = dts_SEC_USERS;
        }

        public void LoadData()
        {
            m_dtsSEC_USERS.SEC_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER.Clear();
            m_dtsSEC_USERS.SEC_USER_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER_TYPE.Clear();


            TA_SEC_ROLE.Fill(m_dtsSEC_USERS.SEC_ROLE);
            TA_SEC_USER.Fill(m_dtsSEC_USERS.SEC_USER);
            TA_SEC_USER_ROLE.Fill(m_dtsSEC_USERS.SEC_USER_ROLE);
            TA_SEC_USER_TYPE.Fill(m_dtsSEC_USERS.SEC_USER_TYPE);
        }

        private int TryGetMaxIdAndIncrementHis()
        {
            int maxId = -1;
            int? tempMaxId = TA_SEC_USER.GetMaxIdFromSEC_USER();
            if (tempMaxId != null) maxId = ((int)tempMaxId) + 1;
            return maxId;
        }

        public void InsertUser(string login, string fio, bool builtIn, bool isDisabled, bool no_check, string typeName)
        {
            int typeId = (int)TA_SEC_USER_TYPE.Get_SEC_USER_TYPE_ID_From_SEC_USER_TYPE_NAME(typeName);
            TA_SEC_USER.InsertNewUser(TryGetMaxIdAndIncrementHis(), login, fio, builtIn, isDisabled, no_check, typeId);
        }

        public void UpdateUser(int id, string login, string fio, bool builtIn, bool isDisabled, bool no_check, string typeName)
        {
            int typeId = (int)TA_SEC_USER_TYPE.Get_SEC_USER_TYPE_ID_From_SEC_USER_TYPE_NAME(typeName);
            TA_SEC_USER.UpdateUser(login, fio, builtIn, isDisabled, no_check, typeId, id);
        }

        public void DeleteUsers(IEnumerable<int> idsUsers)
        {
            foreach (int userId in idsUsers)
            {
                TA_SEC_USER.DeleteUserFromId(userId);
            }
        }

        public bool CheckUserLoginOnUnique(string login)
        {
            return TA_SEC_USER.Check_SEC_USER_LOGIN_IN_SEC_USER(login) == 0;
        }
    }
}

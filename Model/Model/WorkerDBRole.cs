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

        public SecRole CreateSecRole(int selectedRoleId)
        {
            dtsSecUsers dts_SEC_USERS = new dtsSecUsers();

            SEC_ROLETableAdapter ta_SEC_ROLE = new SEC_ROLETableAdapter();
            ta_SEC_ROLE.Connection = ConnectionSingleton.getInstance();

            ta_SEC_ROLE.FillByRole(dts_SEC_USERS.SEC_ROLE, selectedRoleId);

            SecRole role = new SecRole(dts_SEC_USERS);

            return role;
        }

        public SecRole CreateSecRole(int selectedRoleId, int newRoleId)
        {
            dtsSecUsers dts_SEC_USERS = new dtsSecUsers();

            SEC_ROLETableAdapter ta_SEC_ROLE = new SEC_ROLETableAdapter();
            ta_SEC_ROLE.Connection = ConnectionSingleton.getInstance();

            ta_SEC_ROLE.FillByRole(dts_SEC_USERS.SEC_ROLE, selectedRoleId);

            SecRole role = new SecRole(dts_SEC_USERS, newRoleId);

            return role;
        }

        public SecRole CreateSecRole()
        {
            int newRoleId = ((int)TA_SEC_ROLE.GetMax_SEC_ROLE_ID()) + 1;

            dtsSecUsers dts_SEC_USERS = new dtsSecUsers();

            SEC_ROLETableAdapter ta_SEC_ROLE = new SEC_ROLETableAdapter();
            ta_SEC_ROLE.Connection = ConnectionSingleton.getInstance();

            try
            {
                ta_SEC_ROLE.InsertRole(newRoleId, "", false);
            }
            catch(Exception)
            {
                return null;
            }
            
            ta_SEC_ROLE.FillByRole(dts_SEC_USERS.SEC_ROLE, newRoleId);

            SecRole role = new SecRole(dts_SEC_USERS);

            return role;

        }

        public DataView Create_SEC_ROLE_DataView()
        {
            return new DataView(m_dts_SEC_USERS.SEC_ROLE);
        }

        public void DeleteUsers(IEnumerable<int> idsUsers)
        {
            foreach (int userId in idsUsers)
            {
                TA_SEC_ROLE.DeleteRoleFromId(userId);
            }
        }
    }
}

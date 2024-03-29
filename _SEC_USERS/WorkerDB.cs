﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _SEC_USERS;
using _SEC_USERS.dtsSEC_USERSTableAdapters;

namespace _SEC_USERS
{
    public sealed class WorkerDB
    {
        private TableAdapterManager m_ta_Manager;
        private SEC_USERTableAdapter m_ta_SEC_USER;
        private SEC_ROLETableAdapter m_ta_SEC_ROLE;
        private SEC_USER_ROLETableAdapter m_ta_SEC_USER_ROLE;
        private WORKERTableAdapter m_ta_WORKER;
        private SEC_USERTableAdapter m_ta_CURRENT_SEC_USER;
        private SEC_USER_ROLETableAdapter m_ta_CURRENT_SEC_USER_ROLE;
        private SEC_USER_TYPETableAdapter m_ta_SEC_USER_TYPE;
        public string currentLogin;
        private static dtsSEC_USERS m_dtsSEC_USERS = new dtsSEC_USERS();

        public dtsSEC_USERS Get_dts_SEC_USERS
        {
            get
            {
                return m_dtsSEC_USERS;
            }
        }

        public TableAdapterManager TA_MANAGER
        {
            get
            {
                if (m_ta_Manager == null)
                {
                    m_ta_Manager = new TableAdapterManager();
                }
                return m_ta_Manager;
            }
        }

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

        public WORKERTableAdapter TA_WORKER
        {
            get
            {
                if (m_ta_WORKER == null)
                {
                    m_ta_WORKER = new WORKERTableAdapter();
                    m_ta_WORKER.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_WORKER;
            }
        }

        public SEC_USERTableAdapter TA_CURRENT_SEC_USER
        {
            get
            {
                if (m_ta_CURRENT_SEC_USER == null)
                {
                    m_ta_CURRENT_SEC_USER = new SEC_USERTableAdapter();
                    m_ta_CURRENT_SEC_USER.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_CURRENT_SEC_USER;
            }
        }

        public SEC_USER_ROLETableAdapter TA_CURRENT_SEC_USER_ROLE
        {
            get
            {
                if (m_ta_CURRENT_SEC_USER_ROLE == null)
                {
                    m_ta_CURRENT_SEC_USER_ROLE = new SEC_USER_ROLETableAdapter();
                    m_ta_CURRENT_SEC_USER_ROLE.Connection = ConnectionSingleton.getInstance();
                }
                return m_ta_CURRENT_SEC_USER_ROLE;
            }
        }

        public void LoadData()
        {
            LoadData(m_dtsSEC_USERS);
        }

        public void LoadData(dtsSEC_USERS dts_SEC_USERS)
        {
            m_dtsSEC_USERS.SEC_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER.Clear();
            m_dtsSEC_USERS.SEC_USER_ROLE.Clear();
            m_dtsSEC_USERS.SEC_USER_TYPE.Clear();
            m_dtsSEC_USERS.WORKER.Clear();


            TA_SEC_ROLE.Fill(m_dtsSEC_USERS.SEC_ROLE);
            TA_SEC_USER.Fill(m_dtsSEC_USERS.SEC_USER);
            TA_SEC_USER_ROLE.Fill(m_dtsSEC_USERS.SEC_USER_ROLE);
            TA_SEC_USER_TYPE.Fill(m_dtsSEC_USERS.SEC_USER_TYPE);
            TA_WORKER.Fill(m_dtsSEC_USERS.WORKER);
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

        private dtsSEC_USERS CreateDataSetAndFillData(OperationEnum operation, int SecUserId)
        {
            dtsSEC_USERS dts_SEC_USERS = new dtsSEC_USERS();

            if (operation == OperationEnum.Add)
            {
                dtsSEC_USERS.SEC_USERRow New_SEC_USER_Row = dts_SEC_USERS.SEC_USER.NewSEC_USERRow();

                int newUserId = ((int)TA_SEC_USER.GetMaxIdFromSEC_USER()) + 1;

                New_SEC_USER_Row.SEC_USER_ID = newUserId;
                New_SEC_USER_Row.SEC_USER_FIO = "";
                New_SEC_USER_Row.SEC_USER_LOGIN = "";
                New_SEC_USER_Row.SEC_USER_BUILTIN = false;
                New_SEC_USER_Row.SEC_USER_DISABLED = false;
                New_SEC_USER_Row.SEC_USER_NO_CHECK = false;
                New_SEC_USER_Row.SEC_USER_TYPE_ID = 5;

                dts_SEC_USERS.SEC_USER.AddSEC_USERRow(New_SEC_USER_Row);
            }
            else if (operation == OperationEnum.Copy)
            {
                dtsSEC_USERS.SEC_USERRow selectedUser = TA_SEC_USER.GetDataByUser(SecUserId)[0];
                dtsSEC_USERS.SEC_USER_ROLEDataTable userRoles = TA_SEC_USER_ROLE.GetDataByUser(SecUserId);

                dtsSEC_USERS.SEC_USERRow New_SEC_USER_Row = dts_SEC_USERS.SEC_USER.NewSEC_USERRow();

                int newUserId = ((int)TA_SEC_USER.GetMaxIdFromSEC_USER()) + 1;

                New_SEC_USER_Row.SEC_USER_ID = newUserId;
                New_SEC_USER_Row.SEC_USER_FIO = selectedUser.SEC_USER_FIO;
                New_SEC_USER_Row.SEC_USER_LOGIN = selectedUser.SEC_USER_LOGIN;
                New_SEC_USER_Row.SEC_USER_BUILTIN = selectedUser.SEC_USER_BUILTIN;
                New_SEC_USER_Row.SEC_USER_DISABLED = selectedUser.SEC_USER_DISABLED;
                New_SEC_USER_Row.SEC_USER_NO_CHECK = selectedUser.SEC_USER_NO_CHECK;
                New_SEC_USER_Row.SEC_USER_TYPE_ID = selectedUser.SEC_USER_TYPE_ID;
                try
                {
                    New_SEC_USER_Row.SEC_USER_PROCURATORY = selectedUser.SEC_USER_PROCURATORY;
                }
                catch(StrongTypingException)
                {
                    New_SEC_USER_Row.SEC_USER_PROCURATORY = "";
                }
                finally
                {
                    try
                    {
                        New_SEC_USER_Row.SEC_USER_KKM_LOGIN = selectedUser.SEC_USER_KKM_LOGIN;
                    }
                    catch(StrongTypingException)
                    {
                        New_SEC_USER_Row.SEC_USER_KKM_LOGIN = "";
                    }
                    finally
                    {
                        try
                        {
                            New_SEC_USER_Row.SEC_USER_KKM_PASSWORD = selectedUser.SEC_USER_KKM_PASSWORD;
                        }
                        catch(StrongTypingException)
                        {
                            New_SEC_USER_Row.SEC_USER_KKM_PASSWORD = "";
                        }
                        finally
                        {
                            try
                            {
                                New_SEC_USER_Row.SEC_USER_KKM_INN = selectedUser.SEC_USER_KKM_INN;
                            }
                            catch(StrongTypingException)
                            {
                                New_SEC_USER_Row.SEC_USER_KKM_INN = "";
                            }
                        }
                    }
                }

                dts_SEC_USERS.SEC_USER.AddSEC_USERRow(New_SEC_USER_Row);

                foreach (dtsSEC_USERS.SEC_USER_ROLERow userRole in userRoles)
                {
                    dtsSEC_USERS.SEC_USER_ROLERow New_SEC_USER_ROLE_Row = dts_SEC_USERS.SEC_USER_ROLE.NewSEC_USER_ROLERow();

                    New_SEC_USER_ROLE_Row.SEC_USER_ID = newUserId;
                    New_SEC_USER_ROLE_Row.SEC_ROLE_ID = userRole.SEC_ROLE_ID;

                    dts_SEC_USERS.SEC_USER_ROLE.AddSEC_USER_ROLERow(New_SEC_USER_ROLE_Row);
                }
            }
            else if (operation == OperationEnum.Edit)
            {
                TA_CURRENT_SEC_USER.FillByUser(dts_SEC_USERS.SEC_USER, SecUserId);
                TA_CURRENT_SEC_USER_ROLE.FillByUser(dts_SEC_USERS.SEC_USER_ROLE, SecUserId);
            }

            currentLogin = dts_SEC_USERS.SEC_USER.Rows[0].Field<string>("SEC_USER_LOGIN");

            return dts_SEC_USERS;
        }

        public Sec_User CreateSecUser(OperationEnum state, int selectedUserId = 0)
        {
            Sec_User user = new Sec_User(CreateDataSetAndFillData(state, selectedUserId), SaveDataFromSecUser);
            user.SetWorkerDB(this);
            user.SetState(state);
            return user;
        }

        public void UpdateUserDataSet(dtsSEC_USERS userDataSet, int SecUserId)
        {
            userDataSet.SEC_USER.Clear();
            userDataSet.SEC_USER_ROLE.Clear();

            TA_CURRENT_SEC_USER.FillByUser(userDataSet.SEC_USER, SecUserId);
            TA_CURRENT_SEC_USER_ROLE.FillByUser(userDataSet.SEC_USER_ROLE, SecUserId);
        }

        public void Fill_SEC_USER_ROLE_DataTable(dtsSEC_USERS userDataSet, int SecUserId)
        {
            userDataSet.SEC_USER_ROLE.Clear();

            TA_CURRENT_SEC_USER_ROLE.FillByUser(userDataSet.SEC_USER_ROLE, SecUserId);
        }

        public DataView Create_SEC_ROLE_DataView()
        {
            return new DataView(m_dtsSEC_USERS.SEC_ROLE);
        }

        public DataView Create_SEC_USER_TYPE_DataView()
        {
            return new DataView(m_dtsSEC_USERS.SEC_USER_TYPE);
        }

        public DataView Create_WORKER_DataView()
        {
            return new DataView(m_dtsSEC_USERS.WORKER);
        }

        public void CopyRelationsFrom_SEC_USER_ID(int OLD_SEC_USER_ID, int NEW_SEC_USER_ID)
        {
            List<int> SEC_ROLE_IDS = new List<int>();

            foreach (dtsSEC_USERS.SEC_USER_ROLERow row in TA_SEC_USER_ROLE.GetDataByUserTest(OLD_SEC_USER_ID))
            {
                SEC_ROLE_IDS.Add(row.SEC_ROLE_ID);
            }

            foreach (int SEC_ROLE_ID in SEC_ROLE_IDS)
            {
                TA_SEC_USER_ROLE.InsertNewRelationFromUser(SEC_ROLE_ID, NEW_SEC_USER_ID);
            }
        }

        public void DeleteRelationsFrom_SEC_USER_ID(int SEC_USER_ID)
        {
            List<int> SEC_ROLE_IDS = new List<int>();

            foreach (dtsSEC_USERS.SEC_USER_ROLERow row in TA_SEC_USER_ROLE.GetDataByUserTest(SEC_USER_ID))
            {
                SEC_ROLE_IDS.Add(row.SEC_ROLE_ID);
            }

            foreach (int SEC_ROLE_ID in SEC_ROLE_IDS)
            {
                TA_SEC_USER_ROLE.DeleteRelationFromUser(SEC_USER_ID, SEC_ROLE_ID);
            }
        }

        private void SaveDataFromSecUser(dtsSEC_USERS dts_SEC_USERS)
        {
            TA_SEC_USER.Update(dts_SEC_USERS.SEC_USER);
            TA_SEC_USER_ROLE.Update(dts_SEC_USERS.SEC_USER_ROLE);
        }
    }
}

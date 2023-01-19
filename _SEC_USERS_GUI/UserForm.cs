using _SEC_USERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_SEC_USERS.GUI;

namespace _SEC_USERS_GUI
{
    public partial class UserForm : Form
    {
        private WorkerDB m_WorkerDB;
        private FormState m_State;
        private Sec_User m_Sec_User;
        private List<int> m_SEC_ROLE_IDS_From_Undo_Roles;

        public WorkerDB GetWorkerDB
        {
            get
            {
                return m_WorkerDB;
            }
        }

        public UserForm(WorkerDB workerDB, Sec_User secUser)
        {
            InitializeComponent();
            m_WorkerDB = workerDB;
            m_Sec_User = secUser;
            m_SEC_ROLE_IDS_From_Undo_Roles = new List<int>();
        }

        public void SetState(FormState state)
        {
            m_State = state;
            StateRequest();
        }

        internal void StateRequest()
        {
            if (!m_State.TryExecute())
            {
                MessageBox.Show(m_State.ExceptionMessage);
            }
        }

        private void SettingBindingSources()
        {
            bs_SEC_USER.DataSource = m_Sec_User.Create_SEC_USER_DataView();
            bs_SEC_ROLE.DataSource = m_WorkerDB.Create_SEC_ROLE_DataView();
            bs_SEC_USER_TYPE.DataSource = m_WorkerDB.Create_SEC_USER_TYPE_DataView();
            bs_WORKER.DataSource = m_WorkerDB.Create_WORKER_DataView();
            string nameSelectedValueDataBindings = comboBox_TypeUser.DataBindings["SelectedValue"].BindingMemberInfo.BindingMember;
            comboBox_TypeUser.DataBindings.RemoveAt(0);
            comboBox_TypeUser.DataBindings.Add(new Binding("SelectedValue", bs_SEC_USER, nameSelectedValueDataBindings, true));
            nameSelectedValueDataBindings = comboBox_WORKER_FULL_NAME.DataBindings["SelectedValue"].BindingMemberInfo.BindingMember;
            comboBox_WORKER_FULL_NAME.DataBindings.RemoveAt(0);
            comboBox_WORKER_FULL_NAME.DataBindings.Add(new Binding("SelectedValue", bs_WORKER, nameSelectedValueDataBindings, true));
            RoleName.DataSource = bs_SEC_ROLE;
            RoleName.DataPropertyName = RoleName.DataPropertyName;
            RoleName.DisplayMember = RoleName.DisplayMember;
            RoleName.ValueMember = RoleName.ValueMember;
        }

        private void btn_CancelExecute_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dts_SEC_USERS = m_WorkerDB.Get_dts_SEC_USERS;
            SettingBindingSources();

            foreach (dtsSEC_USERS.SEC_USER_ROLERow row in m_WorkerDB.TA_SEC_USER_ROLE.GetDataByUserTest(m_Sec_User.UserId))
            {
                m_SEC_ROLE_IDS_From_Undo_Roles.Add(row.SEC_ROLE_ID);
            }
        }

        public void UndoUserRoles()
        {
            m_WorkerDB.TA_SEC_USER_ROLE.Clear_SEC_ROLE_ID_FROM_SEC_USER_ID(m_Sec_User.UserId);

            foreach (int SEC_ROLE_ID in m_SEC_ROLE_IDS_From_Undo_Roles)
            {
                m_WorkerDB.TA_SEC_USER_ROLE.InsertNewRelationFromUser(SEC_ROLE_ID, m_Sec_User.UserId);
            }
        }

        private void dataGridView_Roles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                DataGridViewCell currentCell = dgv.CurrentCell;
                int columnIndex = currentCell.ColumnIndex;
                int rowIndex = currentCell.RowIndex;
                int countRows = dgv.RowCount;
                if (rowIndex == countRows - 1 && columnIndex > 0)
                {
                    int[] arr = new int[1];
                    Roles form = new Roles(arr);
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        int SEC_ROLE_ID = arr[0];
                        int SEC_USER_ID = m_Sec_User.UserId;
                        try
                        {
                            m_WorkerDB.TA_SEC_USER_ROLE.InsertNewRelationFromUser(SEC_ROLE_ID, SEC_USER_ID);
                        }
                        catch (Exception)
                        {

                        }
                        if (m_State.GetType().ToString().Contains("Adding"))
                        {
                            m_WorkerDB.Fill_SEC_USER_ROLE_DataTable(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                        }
                        else
                        {
                            m_WorkerDB.UpdateUserDataSet(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                        }
                        m_Sec_User.UpdateUserSecRow();
                    }
                }
                else if (columnIndex == 1)
                {
                    int[] arr = new int[1];
                    Roles form = new Roles(arr);
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        int NEW_SEC_ROLE_ID = arr[0];
                        int OLD_SEC_ROLE_ID = (int)dataGridView_Roles[columnIndex - 1, rowIndex].Value;
                        int SEC_USER_ID = m_Sec_User.UserId;
                        try
                        {
                            m_WorkerDB.TA_SEC_USER_ROLE.UpdateRelationFromUser(NEW_SEC_ROLE_ID, OLD_SEC_ROLE_ID, SEC_USER_ID);
                        }
                        catch (Exception)
                        {

                        }
                        if (m_State.GetType().ToString().Contains("Adding"))
                        {
                            m_WorkerDB.Fill_SEC_USER_ROLE_DataTable(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                        }
                        else
                        {
                            m_WorkerDB.UpdateUserDataSet(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                        }
                        m_Sec_User.UpdateUserSecRow();
                    }
                }
                else if (columnIndex == 2)
                {
                    int SEC_ROLE_ID = (int)dataGridView_Roles[columnIndex - 2, rowIndex].Value;
                    int SEC_USER_ID = m_Sec_User.UserId;
                    m_WorkerDB.TA_SEC_USER_ROLE.DeleteRelationFromUser(SEC_USER_ID, SEC_ROLE_ID);
                    if (m_State.GetType().ToString().Contains("Adding"))
                    {
                        m_WorkerDB.Fill_SEC_USER_ROLE_DataTable(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                    }
                    else
                    {
                        m_WorkerDB.UpdateUserDataSet(m_Sec_User.User_dts_SEC_USERS, m_Sec_User.UserId);
                    }
                    m_Sec_User.UpdateUserSecRow();
                }
            }
            catch (NullReferenceException)
            {

            }
            finally
            {
                m_WorkerDB.LoadData();
            }
        }
    }
}

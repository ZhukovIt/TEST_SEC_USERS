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

namespace _SEC_USERS_GUI
{
    public partial class UserForm : Form
    {
        private WorkerDB m_WorkerDB;
        private FormState m_State;
        private Sec_User m_Sec_User;

        public WorkerDB GetWorkerDB
        {
            get
            {
                return m_WorkerDB;
            }
        }

        public UserForm(WorkerDB workerDB, Sec_User secUser)
        {
            m_WorkerDB = workerDB;
            m_Sec_User = secUser;
            InitializeComponent();
            SettingBindingSources();
        }

        private void SettingBindingSources()
        {
            bs_SEC_USER.DataSource = m_Sec_User.Create_SEC_USER_DataView();
            bs_SEC_ROLE.DataSource = m_WorkerDB.Create_SEC_ROLE_DataView();
            bs_SEC_USER_TYPE.DataSource = m_WorkerDB.Create_SEC_USER_TYPE_DataView();
            bs_SEC_USER_FROM_SEC_ROLES.DataSource = bs_SEC_USER;
            bs_SEC_USER_FROM_SEC_ROLES.DataMember = "FK_SEC_USER_SEC_USER__SEC_USER";
            RoleName.DisplayMember = "SEC_ROLE_NAME";
            RoleName.ValueMember = "SEC_ROLE_ID";
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

        private void btn_CancelExecute_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}

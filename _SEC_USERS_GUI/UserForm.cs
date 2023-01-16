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
        private FormState m_State;
        private WorkerDB m_WorkerDB;
        private Sec_User m_Sec_User;

        public WorkerDB GetWorkerDB
        {
            get
            {
                return m_WorkerDB;
            }
        }

        public UserForm(Sec_User secUser)
        {
            InitializeComponent();
            m_Sec_User = secUser;
            bs_SEC_USER.DataSource = m_Sec_User.Create_SEC_USER_DataView();
            //bs_SEC_ROLE.DataSource = m_Sec_User.Create_SEC_ROLE_DataView();
            bs_SEC_USER_TYPE.DataSource = m_Sec_User.Create_SEC_USER_TYPE_DataView();
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

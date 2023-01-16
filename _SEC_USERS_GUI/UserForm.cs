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

        public WorkerDB GetWorkerDB
        {
            get
            {
                return m_WorkerDB;
            }
        }

        public UserForm()
        {
            InitializeComponent();
            m_WorkerDB = new WorkerDB(dts_SEC_USERS);
            m_WorkerDB.LoadData();
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

        private void btn_AddNewRole_Click(DataGridViewButtonCell sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_RemoveRole_Click(DataGridViewButtonCell sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_Roles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewButtonCell senderButton = (DataGridViewButtonCell)dgv.CurrentCell;
            int columnIndex = senderButton.ColumnIndex;
            if (columnIndex == 1)
            {
                btn_AddNewRole_Click(senderButton, e);
            }
            else if (columnIndex == 2)
            {
                btn_RemoveRole_Click(senderButton, e);
            }
        }
    }
}

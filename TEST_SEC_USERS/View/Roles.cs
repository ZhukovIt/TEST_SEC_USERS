using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST_SEC_USERS;

namespace TEST_SEC_USERS.GUI
{
    public partial class Roles : Form
    {
        private WorkerDBRole m_workerDBRole;
        private int m_Select_SEC_ROLE_ID;

        public Roles()
        {
            InitializeComponent();
            m_workerDBRole = new WorkerDBRole();
            m_workerDBRole.LoadData();
            dtsSecUsers = m_workerDBRole.Get_dts_SEC_USERS;
            bsSEC_ROLE.DataSource = m_workerDBRole.Create_SEC_ROLE_DataView();
            PrepareFormForGive_SEC_ROLE_ID();
        }

        public Roles(ref int SEC_ROLE_ID) : this()
        {
            PrepareFormForGive_SEC_ROLE_ID();
            m_Select_SEC_ROLE_ID = SEC_ROLE_ID;
        }
    }
}

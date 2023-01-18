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

namespace TEST_SEC_USERS.View
{
    public partial class Role : Form
    {
        private WorkerDBRole m_WorkerDBRole;
        private SecRole m_SecRole;
        private RoleStateEnum m_state;

        public Role(RoleStateEnum state, WorkerDBRole workerDBRole, SecRole secRole)
        {
            InitializeComponent();
            m_state = state;
            m_WorkerDBRole = workerDBRole;
            m_SecRole = secRole;
            dtsSecUsers = m_WorkerDBRole.Get_dts_SEC_USERS;
            bs_SEC_ROLE.DataSource = m_SecRole.Create_SEC_ROLE_DataView();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            int roleId = m_SecRole.RoleId;
            string roleName = m_SecRole.RoleName;
            bool roleBuiltIn = m_SecRole.RoleBuiltIn;

            try
            {
                if (m_state == RoleStateEnum.Editing)
                {
                    m_WorkerDBRole.TA_SEC_ROLE.UpdateUser(roleName, roleBuiltIn, roleId);
                }
                else
                {

                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}

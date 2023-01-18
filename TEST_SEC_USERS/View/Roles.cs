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
using Model;
using TEST_SEC_USERS.View;

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

        private void btnAddNewRole_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyRole_Click(object sender, EventArgs e)
        {
            int selectedRoleId = ((DataRowView)bsSEC_ROLE.Current).Row.Field<int>("SEC_ROLE_ID");
            SecRole currentRole = m_workerDBRole.CreateSecRole(selectedRoleId);
            Role form = new Role(RoleStateEnum.Editing, m_workerDBRole, currentRole);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_workerDBRole.LoadData();
                dgv_SEC_ROLE.Update();
                int Pos = bsSEC_ROLE.Find("SEC_ROLE_ID", selectedRoleId);
                if (Pos >= 0)
                {
                    bsSEC_ROLE.Position = Pos;
                }
            }
        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            int selectedRoleId = ((DataRowView)bsSEC_ROLE.Current).Row.Field<int>("SEC_ROLE_ID");
            SecRole currentRole = m_workerDBRole.CreateSecRole(selectedRoleId);
            Role form = new Role(RoleStateEnum.Editing, m_workerDBRole, currentRole);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_workerDBRole.LoadData();
                dgv_SEC_ROLE.Update();
            }
            int Pos = bsSEC_ROLE.Find("SEC_ROLE_ID", selectedRoleId);
            if (Pos >= 0)
            {
                bsSEC_ROLE.Position = Pos;
            }
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            List<string> RoleNames = new List<string>();

            foreach (DataGridViewRow row in dgv_SEC_ROLE.SelectedRows)
            {

                RoleNames.Add((string)row.Cells[0].Value);
            }

            DialogResult dialogResult = new _SEC_USERS_GUI.DeleteAnswerForm(RoleNames.Count).ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                DoDeleteUsersFromUserIds(RoleNames);
            }
        }

        private void DoDeleteUsersFromUserIds(IEnumerable<string> RoleNames)
        {
            List<int> rolesIds = new List<int>();

            foreach (DataRowView row in bsSEC_ROLE.List)
            {
                if (((List<string>)RoleNames).Contains(row.Row.Field<string>("SEC_ROLE_NAME")))
                {
                    rolesIds.Add(row.Row.Field<int>("SEC_ROLE_ID"));
                }
            }

            m_workerDBRole.DeleteUsers(rolesIds);
            m_workerDBRole.LoadData();
            dgv_SEC_ROLE.Update();
        }

        private void btnClearFinderRoles_Click(object sender, EventArgs e)
        {
            tbox_Roles.Text = "";
            tbox_Roles.Focus();
        }

        private void tbox_Roles_TextChanged(object sender, EventArgs e)
        {
            bsSEC_ROLE.Filter = $"SEC_ROLE_NAME LIKE '%{tbox_Roles.Text}%'";
        }

        private void dgv_SEC_ROLE_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditRole_Click(sender, e);
        }
    }
}

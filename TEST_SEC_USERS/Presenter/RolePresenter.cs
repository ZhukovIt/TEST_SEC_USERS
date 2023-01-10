using TEST_SEC_USERS.GUI;
using Model;
using Model.dtsSecUsersTableAdapters;
using System;
using System.Windows.Forms;

namespace TEST_SEC_USERS.Presenter
{
    public class RolePresenter : AbstractPresenter
    {
        public RolePresenter(Roles view, Model.ModelWorker model) : base(view, model)
        {
            m_dtsSec = view.DTS_SEC_USERS;
            m_taSec = view.TA_SEC_USERS;
            view.SetPresenter(this);
        }

        public override void LoadDataSource()
        {
            var m_dtsSecRole = (dtsSecUsers)m_dtsSec;
            var m_taSecRole = (SEC_ROLETableAdapter)m_taSec;
            m_dtsSecRole.SEC_ROLE.Clear();
            m_taSecRole.Fill(m_dtsSecRole.SEC_ROLE);
        }

        // Методы-обработчики для формы Roles..................
        internal void btnAddNewRole_Click(object sender, EventArgs e)
        {
            
        }

        internal void btnCopyRole_Click(object sender, EventArgs e)
        {

        }

        internal void btnEditRole_Click(object sender, EventArgs e)
        {

        }

        internal void btnRemoveRole_Click(object sender, EventArgs e)
        {

        }

        internal void btnRefreshRole_Click(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        internal void btnClearFinderRoles_Click(object sender, EventArgs e)
        {
            var finderTextBox = ((Roles)m_view).FinderTextBox;
            finderTextBox.Text = "";
            finderTextBox.Focus();
        }

        internal void tbox_Roles_TextChanged(object sender, EventArgs e)
        {
            var finderTextBox = (ToolStripTextBox)sender;
            ((Roles)m_view).BS_SEC_ROLE.Filter = $"SEC_ROLE_NAME LIKE '%{finderTextBox.Text}%'";
        }

        //.....................................................
    }
}

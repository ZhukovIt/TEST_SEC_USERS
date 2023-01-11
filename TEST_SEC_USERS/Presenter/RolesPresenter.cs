using TEST_SEC_USERS.GUI;
using Model;
using Model.dtsSecUsersTableAdapters;
using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using TEST_SEC_USERS.Extensions;
using TEST_SEC_USERS.View;

namespace TEST_SEC_USERS.Presenter
{
    public class RolesPresenter : AbstractPresenter
    {
        private readonly List<string> m_RemovedRowsId;

        public RolesPresenter(Roles view, Model.ModelWorker model) : base(view, model)
        {
            m_RemovedRowsId = new List<string>();
            m_dtsSec = view.DTS_SEC_USERS;
            m_taSec = view.TA_SEC_USERS;
            m_bsSec = view.BS_SEC_ROLE;
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
            new Role(new AddingState()).ShowDialog();
        }

        internal void btnCopyRole_Click(object sender, EventArgs e)
        {
            BindingSource bs = (BindingSource)m_bsSec;
            DataRow current = (DataRow)bs.Current;
            if (bs.Current != null)
            {
                new Role(new CopyingState()).ShowDialog();
            }
        }

        internal void btnEditRole_Click(object sender, EventArgs e)
        {
            BindingSource bs = (BindingSource)m_bsSec;
            if (bs.Current != null)
            {
                new Role(new EditingState()).ShowDialog();
            }
        }

        internal void btnRemoveRole_Click(object sender, EventArgs e)
        {
            var selectedRows = ((Roles)m_view).DGV_SEC_ROLE.SelectedRows;
            selectedRows.StrikeSelectedRowsExtensions(m_RemovedRowsId);
        }

        internal void btnSaveChanges_Click(object sender, EventArgs e)
        {
            BindingSource bs = (BindingSource)m_bsSec;
            dtsSecUsers m_dtsSecRole = (dtsSecUsers)m_dtsSec;
            SEC_ROLETableAdapter m_taSecRole = (SEC_ROLETableAdapter)m_taSec;
            foreach (DataRowView element in bs.List)
            {
                if (m_RemovedRowsId.Contains(element.Row.Field<string>("SEC_ROLE_NAME")))
                {
                    bs.Remove(element);
                }
            }
            m_taSecRole.Update(m_dtsSecRole.SEC_ROLE);
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

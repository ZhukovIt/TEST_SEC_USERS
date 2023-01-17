using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _SEC_USERS;

namespace _SEC_USERS_GUI
{
    public partial class UsersForm : Form
    {
        private WorkerDB m_WorkerDB;

        public UsersForm()
        {
            InitializeComponent();
            m_WorkerDB = new WorkerDB();
            m_WorkerDB.LoadData();
            bs_SEC_USERS.DataSource = m_WorkerDB.Get_dts_SEC_USERS;
            bs_SEC_USER_TYPE.DataSource = m_WorkerDB.Get_dts_SEC_USERS;
        }

        private void DoDeleteUsersFromUserIds(IEnumerable<string> loginStrings)
        {
            List<int> userIds = new List<int>();

            foreach (DataRowView row in bs_SEC_USERS.List)
            {
                if (((List<string>)loginStrings).Contains(row.Row.Field<string>("SEC_USER_LOGIN")))
                {
                    userIds.Add(row.Row.Field<int>("SEC_USER_ID"));
                }
            }

            m_WorkerDB.DeleteUsers(userIds);
            m_WorkerDB.LoadData();
            dgv_SEC_USERS.Update();
        }


        // Методы-обработчики событий

        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {
            int newUserId = ((int)m_WorkerDB.TA_SEC_USER.GetMaxIdFromSEC_USER()) + 1;
            Sec_User currentUser = m_WorkerDB.CreateSecUser(newUserId, true);
            if (currentUser == null)
            {
                int emptyLoginId = (int)m_WorkerDB.TA_SEC_USER.GetIdFromEmpltyLogin();
                m_WorkerDB.TA_SEC_USER.DeleteUserFromId(emptyLoginId);
                currentUser = m_WorkerDB.CreateSecUser(newUserId, true);
            }
            UserForm form = new UserForm(m_WorkerDB, currentUser);
            FormState state = new UserFormAddingState(form, currentUser);
            form.SetState(state);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_WorkerDB.LoadData();
                dgv_SEC_USERS.Update();
                int Pos = bs_SEC_USERS.Find("SEC_USER_ID", newUserId);
                if (Pos >= 0)
                {
                    bs_SEC_USERS.Position = Pos;
                }
            }
        }

        private void btn_AddNewUserWithCopy_Click(object sender, EventArgs e)
        {
            int selectedUserId = ((DataRowView)bs_SEC_USERS.Current).Row.Field<int>("SEC_USER_ID");
            int newUserId = ((int)m_WorkerDB.TA_SEC_USER.GetMaxIdFromSEC_USER()) + 1;
            Sec_User currentUser = m_WorkerDB.CreateSecUser(newUserId, selectedUserId);
            UserForm form = new UserForm(m_WorkerDB, currentUser);
            FormState state = new UserFormCopyingState(form, currentUser);
            form.SetState(state);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_WorkerDB.LoadData();
                dgv_SEC_USERS.Update();
            }
            int Pos = bs_SEC_USERS.Find("SEC_USER_ID", newUserId);
            if (Pos >= 0)
            {
                bs_SEC_USERS.Position = Pos;
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            int selectedUserId = ((DataRowView)bs_SEC_USERS.Current).Row.Field<int>("SEC_USER_ID");
            Sec_User currentUser = m_WorkerDB.CreateSecUser(selectedUserId);
            UserForm form = new UserForm(m_WorkerDB, currentUser);
            FormState state = new UserFormEditingState(form, currentUser);
            form.SetState(state);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                m_WorkerDB.LoadData();
                dgv_SEC_USERS.Update();
            }
            int Pos = bs_SEC_USERS.Find("SEC_USER_ID", selectedUserId);
            if (Pos >= 0)
            {
                bs_SEC_USERS.Position = Pos;
            }
        }

        private void btn_RemoveUser_Click(object sender, EventArgs e)
        {
            List<string> loginStrings = new List<string>();

            foreach (DataGridViewRow row in dgv_SEC_USERS.SelectedRows)
            {
                loginStrings.Add((string)row.Cells[1].Value);
            }

            DialogResult dialogResult = new DeleteAnswerForm(loginStrings.Count).ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                DoDeleteUsersFromUserIds(loginStrings);
            }
        }

        // Для добавления новых условий фильтра в данный метод, достаточно
        // добавить проверяемый атрибут(столбец) в список items
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            string enterText = ((ToolStripTextBox)sender).Text;
            List<string> items = new List<string>
            {
                "SEC_USER_LOGIN",
                "SEC_USER_FIO"
            };
            bs_SEC_USERS.Filter = items.JoinConditionsExtensions($" LIKE '%{enterText}%'", " OR ");
        }

        private void btn_ClearFinder_Click(object sender, EventArgs e)
        {
            txtBox_FinderField.Text = "";
            txtBox_FinderField.Focus();
        }

        private void dgv_SEC_USERS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_EditUser_Click(sender, e);
        }
    }
}
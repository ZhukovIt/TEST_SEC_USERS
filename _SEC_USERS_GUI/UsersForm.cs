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
            bs_SEC_USERS.DataSource = m_WorkerDB.dts_SEC_USERS;
            bs_SEC_USER_TYPE.DataSource = m_WorkerDB.dts_SEC_USERS;
            m_WorkerDB.LoadData();
        }

        private Tuple<int, string, string, bool, bool, bool, int> CreateCurrentUserData()
        {
            DataRow dataRow = ((DataRowView)bs_SEC_USERS.Current).Row;
            int id = dataRow.Field<int>("SEC_USER_ID");
            string login = dataRow.Field<string>("SEC_USER_LOGIN");
            string fio = dataRow.Field<string>("SEC_USER_FIO");
            bool builtIn = dataRow.Field<bool>("SEC_USER_BUILTIN");
            bool isDisabled = dataRow.Field<bool>("SEC_USER_DISABLED");
            bool noCheck = dataRow.Field<bool>("SEC_USER_NO_CHECK");
            int typeId = dataRow.Field<int>("SEC_USER_TYPE_ID");
            return Tuple.Create(id, login, fio, builtIn, isDisabled, noCheck, typeId);
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
            //UserForm form = new UserForm();
            //FormState state = new UserFormAddingState(form);
            //form.SetState(state);
            //form.ShowDialog();
            //m_WorkerDB.LoadData();
            //dgv_SEC_USERS.Update();
        }

        private void btn_AddNewUserWithCopy_Click(object sender, EventArgs e)
        {
            //UserForm form = new UserForm();
            //FormState state = new UserFormCopyingState(form);
            //state.FillMembersData(CreateCurrentUserData());
            //form.SetState(state);
            //form.ShowDialog();
            //m_WorkerDB.LoadData();
            //dgv_SEC_USERS.Update();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            int selectedUserId = ((DataRowView)bs_SEC_USERS.Current).Row.Field<int>("SEC_USER_ID");
            Sec_User currentUser = m_WorkerDB.CreateSecUser(selectedUserId);
            new UserForm(currentUser).ShowDialog();

            //FormState state = new UserFormEditingState(form);
            //state.FillMembersData(CreateCurrentUserData());
            //form.SetState(state);
            //form.ShowDialog();
            //m_WorkerDB.LoadData();
            //dgv_SEC_USERS.Update();
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
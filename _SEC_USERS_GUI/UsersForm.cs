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
            m_WorkerDB = new WorkerDB(dts_SEC_USERS);
            m_WorkerDB.LoadData();
        }





        // Методы-обработчики событий






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
    }
}
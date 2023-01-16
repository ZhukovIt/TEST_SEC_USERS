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
    public partial class DeleteAnswerForm : Form
    {
        public DeleteAnswerForm(int countSelectedRows)
        {
            InitializeComponent();
            textBox_Information.Text = $"Вы точно хотите удалить {countSelectedRows} выбранных пользователей?";
        }

        private void btn_YesAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btn_NoAnswer_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

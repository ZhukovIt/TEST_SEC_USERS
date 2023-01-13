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
        public UsersForm()
        {
            InitializeComponent();
            new WorkerDB(dts_SEC_USERS).LoadData();
        }
    }
}

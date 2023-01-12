using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SECURITY_USERS
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            new WorkerDB(dts_SEC_USERS).InsertUser(params??????);
        }
    }
}

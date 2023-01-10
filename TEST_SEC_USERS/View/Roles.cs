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

namespace TEST_SEC_USERS.GUI
{
    public partial class Roles : Form
    {
        private Presenter.Presenter m_presenter;

        public Roles()
        {
            InitializeComponent();
            m_presenter = new Presenter.Presenter(this, new Model.ModelWorker());
        }

        public void SetPresenter(Presenter.Presenter presenter)
        {
            m_presenter = presenter;
        }

        public BindingSource BS_SEC_ROLE
        {
            get
            {
                return bsSEC_ROLE;
            }
        }

        public Model.dtsSecUsers DTS_SEC_USERS
        {
            get
            {
                return dtsSecUsers;
            }
        }

        public Model.dtsSecUsersTableAdapters.SEC_ROLETableAdapter TA_SEC_USERS
        {
            get
            {
                return seC_ROLETableAdapter;
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            m_presenter.LoadDataSource();
        }
    }
}

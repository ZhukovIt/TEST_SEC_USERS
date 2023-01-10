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
        private Presenter.RolesPresenter m_presenter;

        public Roles()
        {
            InitializeComponent();
            m_presenter = new Presenter.RolesPresenter(this, new Model.ModelWorker());
            SetEventHandlersFromUIElements();
        }

        public void SetPresenter(Presenter.RolesPresenter presenter)
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

        internal ToolStripTextBox FinderTextBox
        {
            get
            {
                return tbox_Roles;
            }
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            m_presenter.LoadDataSource();
        }

        private void SetEventHandlersFromUIElements()
        {
            btnAddNewRole.Click += new EventHandler(m_presenter.btnAddNewRole_Click);
            btnCopyRole.Click += new EventHandler(m_presenter.btnCopyRole_Click);
            btnEditRole.Click += new EventHandler(m_presenter.btnEditRole_Click);
            btnRemoveRole.Click += new EventHandler(m_presenter.btnRemoveRole_Click);
            btnRefreshRoles.Click += new EventHandler(m_presenter.btnRefreshRole_Click);
            btnClearFinderRoles.Click += new EventHandler(m_presenter.btnClearFinderRoles_Click);
            tbox_Roles.TextChanged += new EventHandler(m_presenter.tbox_Roles_TextChanged);
        }
    }
}

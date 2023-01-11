using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_SEC_USERS.View
{
    public partial class Role : Form
    {
        private Presenter.RolePresenter m_presenter;

        public Role()
        {
            InitializeComponent();
        }

        internal void SetPresenter(Presenter.RolePresenter presenter)
        {
            m_presenter = presenter;
        }
    }
}

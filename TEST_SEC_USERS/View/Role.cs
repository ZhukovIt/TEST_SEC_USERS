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
        private FormState m_State;

        public Role()
        {
            InitializeComponent();
        }

        public Role(FormState state) : this()
        {
            m_State = state;
            StateRequest();
        }

        internal void SetPresenter(Presenter.RolePresenter presenter)
        {
            m_presenter = presenter;
        }

        internal void StateRequest()
        {
            m_State.FillData(this);
        }
    }
}

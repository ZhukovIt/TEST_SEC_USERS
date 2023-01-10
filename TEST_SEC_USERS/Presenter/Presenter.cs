using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST_SEC_USERS.GUI;

namespace TEST_SEC_USERS.Presenter
{
    public class Presenter
    {
        private readonly Model.ModelWorker m_model;
        private readonly Roles m_view;
        private Model.dtsSecUsers m_dtsSecUsers;
        private Model.dtsSecUsersTableAdapters.SEC_ROLETableAdapter m_taSecUsers;

        public Presenter(Roles view, Model.ModelWorker model)
        {
            m_view = view;
            m_model = model;
            m_dtsSecUsers = m_view.DTS_SEC_USERS;
            m_taSecUsers = m_view.TA_SEC_USERS;
            m_view.SetPresenter(this);
        }

        public void LoadDataSource()
        {
            m_dtsSecUsers.SEC_ROLE.Clear();
            m_taSecUsers.Fill(m_dtsSecUsers.SEC_ROLE);
        }
    }
}

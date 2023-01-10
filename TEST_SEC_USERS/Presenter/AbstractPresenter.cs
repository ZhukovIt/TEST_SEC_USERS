using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_SEC_USERS.Presenter
{
    public abstract class AbstractPresenter
    {
        protected Model.ModelWorker m_model;
        protected Form m_view;
        protected DataSet m_dtsSec;
        protected Component m_taSec;

        protected AbstractPresenter(Form view, Model.ModelWorker model)
        {
            m_view = view;
            m_model = model;
        }

        public abstract void LoadDataSource();
    }
}

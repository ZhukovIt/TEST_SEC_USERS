using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_SEC_USERS.Presenter
{
    public class Presenter
    {
        private readonly Form m_view;
        private readonly Model.ModelWorker m_model;

        public Presenter(Form view, Model.ModelWorker model)
        {
            m_view = view;
            m_model = model;
            
        }

        
    }
}

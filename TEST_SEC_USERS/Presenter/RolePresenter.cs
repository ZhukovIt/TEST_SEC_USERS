using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using TEST_SEC_USERS.View;

namespace TEST_SEC_USERS.Presenter
{
    internal class RolePresenter : AbstractPresenter
    {
        public RolePresenter(Role view, RoleWorker model) : base(view, model)
        {
            
        }

        public override void LoadDataSource()
        {
            throw new NotImplementedException();
        }
    }
}

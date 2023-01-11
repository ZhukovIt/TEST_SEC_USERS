using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_SEC_USERS.View
{
    public abstract class FormState
    {
        protected string m_Name;
        protected bool m_BuiltIn;

        public abstract void FillData(Form form);
    }

    public class AddingState : FormState
    {
        public override void FillData(Form form)
        {

        }
    }

    public class CopyingState : FormState
    {
        public override void FillData(Form form)
        {

        }
    }

    public class EditingState : FormState
    {
        public override void FillData(Form form)
        {

        }
    }
}

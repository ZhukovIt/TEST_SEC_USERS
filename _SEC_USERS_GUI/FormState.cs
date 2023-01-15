using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _SEC_USERS_GUI
{
    public abstract class FormState
    {
        protected int m_Id;
        protected string m_Login;
        protected string m_FIO;
        protected bool m_BuiltIn;
        protected bool m_Disabled;
        protected bool m_NoCheck;
        protected int m_TypeId;
        protected string m_ExceptionMessage;

        public string ExceptionMessage
        {
            get
            {
                return m_ExceptionMessage;
            }
        }

        public bool TryExecute(Form form)
        {
            try
            {
                FillData(form);
                return true;
            }
            catch (Exception ex)
            {
                m_ExceptionMessage = ex.Message;
                return false;
            }
        }

        internal abstract void FillData(Form form);
    }

    public sealed class UserFormAddingState : FormState
    {
        internal override void FillData(Form t_form)
        {
            UserForm form = (UserForm)t_form;

            
            //form.GetWorkerDB.InsertUser();
        }
    }

    public sealed class UserFormCopyingState : FormState
    {
        internal override void FillData(Form t_form)
        {
            UserForm form = (UserForm)t_form;


        }
    }

    public sealed class UserFormEditingState : FormState
    {
        internal override void FillData(Form t_form)
        {
            UserForm form = (UserForm)t_form;


        }
    }
}

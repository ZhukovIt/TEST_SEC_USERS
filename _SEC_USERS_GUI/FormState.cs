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

        public bool TryExecute()
        {
            try
            {
                FillData();
                return true;
            }
            catch (Exception ex)
            {
                m_ExceptionMessage = ex.Message;
                return false;
            }
        }

        internal abstract void FillData();
    }

    public abstract class UserFormState : FormState
    {
        protected readonly UserForm m_form;
        protected readonly Button m_SaveButton;

        protected UserFormState(UserForm form)
        {
            m_form = form;
            m_SaveButton = m_form.GetButtonSaveExecute;
            m_SaveButton.Click += new EventHandler(EventHandlerFromSaveButton);
        }

        internal abstract void EventHandlerFromSaveButton(object sender, EventArgs e);
    }

    public sealed class UserFormAddingState : UserFormState
    {
        public UserFormAddingState(UserForm form) : base(form)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Добавление нового пользователя";
            m_SaveButton.Text = "Добавить";
            
            
            //form.GetWorkerDB.InsertUser();
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {
            
        }
    }

    public sealed class UserFormCopyingState : UserFormState
    {
        public UserFormCopyingState(UserForm form) : base(form)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Создание нового пользователя на основе копии";
            m_SaveButton.Text = "Добавить";

            //form.GetWorkerDB.InsertUser();
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {

        }
    }

    public sealed class UserFormEditingState : UserFormState
    {
        public UserFormEditingState(UserForm form) : base(form)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Редактирование пользователя";

            //form.GetWorkerDB.InsertUser();
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {

        }
    }
}

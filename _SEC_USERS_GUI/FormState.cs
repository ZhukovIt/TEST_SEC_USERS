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
        protected int? m_WorkId;
        protected string m_Procuratory;
        protected string m_KKM_LOGIN;
        protected string m_KKM_PASSWORD;
        protected string m_KKM_INN;
        protected string m_TypeUser_Name;
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
        protected readonly _SEC_USERS.WorkerDB m_WorkerDB;
        protected readonly Button m_SaveButton;
        protected readonly _SEC_USERS.Sec_User m_SecUser;

        protected UserFormState(UserForm form, _SEC_USERS.Sec_User secUser)
        {
            m_form = form;
            m_SecUser = secUser;
            m_WorkerDB = m_form.GetWorkerDB;
            m_SaveButton = m_form.GetButtonSaveExecute;
            m_SaveButton.Click += new EventHandler(EventHandlerFromSaveButton);
            m_SaveButton.Click += new EventHandler(DopEventHandlerFromSaveButton);
        }

        internal override void FillData()
        {
            m_Id = m_SecUser.UserId;
            m_Login = m_SecUser.UserLogin;
            m_FIO = m_SecUser.UserFIO;
            m_BuiltIn = m_SecUser.BuiltIn;
            m_Disabled = m_SecUser.IsDisabled;
            m_NoCheck = m_SecUser.NoCheck;
            m_TypeId = m_SecUser.TypeId;
            m_WorkId = m_SecUser.WorkId;
            m_KKM_LOGIN = m_SecUser.KKM_LOGIN;
            m_KKM_PASSWORD = m_SecUser.KKM_PASSWORD;
            m_KKM_INN = m_SecUser.KKM_INN;
        }

        private void DopEventHandlerFromSaveButton(object sender, EventArgs e)
        {
            m_WorkerDB.TA_SEC_USER.Update(m_WorkerDB.Get_dts_SEC_USERS);
            m_form.DialogResult = DialogResult.OK;
        }

        internal abstract void EventHandlerFromSaveButton(object sender, EventArgs e);
    }

    public sealed class UserFormAddingState : UserFormState
    {
        public UserFormAddingState(UserForm form, _SEC_USERS.Sec_User secUser) : base(form, secUser)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Добавление нового пользователя";
            m_SaveButton.Text = "Добавить";
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {
            base.FillData();
            try
            {
                m_WorkerDB.TA_SEC_USER.UpdateUser(m_Login, m_FIO, m_BuiltIn, m_Disabled, m_NoCheck, m_TypeId, m_WorkId, m_Procuratory, m_KKM_LOGIN, m_KKM_PASSWORD, m_KKM_INN, m_Id);
            }
            catch (Exception)
            {
                m_WorkerDB.TA_SEC_USER.DeleteUserFromId(m_Id);
            }
        }
    }

    public sealed class UserFormCopyingState : UserFormState
    {
        public UserFormCopyingState(UserForm form, _SEC_USERS.Sec_User secUser) : base(form, secUser)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Создание нового пользователя на основе копии";
            m_form.Width += 20;
            m_SaveButton.Text = "Добавить";
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {
            base.FillData();
            try
            {
                m_WorkerDB.TA_SEC_USER.UpdateUser(m_Login, m_FIO, m_BuiltIn, m_Disabled, m_NoCheck, m_TypeId, m_WorkId, m_Procuratory, m_KKM_LOGIN, m_KKM_PASSWORD, m_KKM_INN, m_Id);
            }
            catch (Exception)
            {

            }

        }
    }

    public sealed class UserFormEditingState : UserFormState
    {
        public UserFormEditingState(UserForm form, _SEC_USERS.Sec_User secUser) : base(form, secUser)
        {

        }

        internal override void FillData()
        {
            m_form.Text = "Редактирование пользователя";
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {
            m_SecUser.Save();
            try
            {
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
                
            }
            catch (Exception)
            {

            }
        }
    }
}

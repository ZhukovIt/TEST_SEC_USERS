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
                FillFormData();
                return true;
            }
            catch (Exception ex)
            {
                m_ExceptionMessage = ex.Message;
                return false;
            }
        }

        internal void FillMembersData(Tuple<int, string, string, bool, bool, bool, int> userData)
        {
            m_Id = userData.Item1;
            m_Login = userData.Item2;
            m_FIO = userData.Item3;
            m_BuiltIn = userData.Item4;
            m_Disabled = userData.Item5;
            m_NoCheck = userData.Item6;
            m_TypeId = userData.Item7;
        }

        internal abstract void FillFormData();
    }

    public abstract class UserFormState : FormState
    {
        protected readonly UserForm m_form;
        protected readonly _SEC_USERS.WorkerDB m_WorkerDB;
        protected readonly Button m_SaveButton;
        protected readonly TextBox m_FIOTextBox;
        protected readonly TextBox m_LoginTextBox;
        protected readonly ComboBox m_UserTypeComboBox;
        protected readonly CheckBox m_BuiltInCheckBox;
        protected readonly CheckBox m_DisabledCheckBox;
        protected readonly CheckBox m_NoCheckCheckBox;

        protected UserFormState(UserForm form)
        {
            m_form = form;
            m_WorkerDB = m_form.GetWorkerDB;
            m_SaveButton = m_form.GetButtonSaveExecute;
            m_FIOTextBox = m_form.GetFIOTextBox;
            m_LoginTextBox = m_form.GetLoginTextBox;
            m_UserTypeComboBox = m_form.GetUserTypeComboBox;
            m_BuiltInCheckBox = m_form.GetBuiltInCheckBox;
            m_DisabledCheckBox = m_form.GetIsDisabledCheckBox;
            m_NoCheckCheckBox = m_form.GetNoCheckCheckBox;
            m_SaveButton.Click += new EventHandler(EventHandlerFromSaveButton);
        }

        protected void FillAllFieldsOnForm()
        {
            m_FIOTextBox.Text = m_FIO;
            m_LoginTextBox.Text = m_Login;
            m_UserTypeComboBox.SelectedItem = m_UserTypeComboBox;
            m_BuiltInCheckBox.Checked = m_BuiltInCheckBox.Checked;
            m_DisabledCheckBox.Checked = m_DisabledCheckBox.Checked;
            m_NoCheckCheckBox.Checked = m_NoCheckCheckBox.Checked;
        }

        internal abstract void EventHandlerFromSaveButton(object sender, EventArgs e);
    }

    public sealed class UserFormAddingState : UserFormState
    {
        public UserFormAddingState(UserForm form) : base(form)
        {

        }

        internal override void FillFormData()
        {
            m_form.Text = "Добавление нового пользователя";
            m_SaveButton.Text = "Добавить";
            
            
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {
            //form.GetWorkerDB.InsertUser();
            
        }
    }

    public sealed class UserFormCopyingState : UserFormState
    {
        public UserFormCopyingState(UserForm form) : base(form)
        {

        }

        internal override void FillFormData()
        {
            m_form.Text = "Создание нового пользователя на основе копии";
            m_form.Width += 20;
            m_SaveButton.Text = "Добавить";
            FillAllFieldsOnForm();

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

        internal override void FillFormData()
        {
            m_form.Text = "Редактирование пользователя";
            FillAllFieldsOnForm();

            //form.GetWorkerDB.InsertUser();
        }

        internal override void EventHandlerFromSaveButton(object sender, EventArgs e)
        {

        }
    }
}

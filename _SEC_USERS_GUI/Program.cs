using _SEC_USERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _SEC_USERS_GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UsersForm());
            UserForm form = new UserForm();
            form.SetState(new UserFormAddingState(form));
            Application.Run(form);
        }
    }
}

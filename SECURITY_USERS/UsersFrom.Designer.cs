
namespace SECURITY_USERS_GUI
{
    partial class UsersForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.ts_HeaderButtons = new System.Windows.Forms.ToolStrip();
            this.btn_AddNewUser = new System.Windows.Forms.ToolStripButton();
            this.btn_AddNewUserWithCopy = new System.Windows.Forms.ToolStripButton();
            this.btn_EditUset = new System.Windows.Forms.ToolStripButton();
            this.btn_RemoveUser = new System.Windows.Forms.ToolStripButton();
            this.sep_ButtonsToFinder = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_FinderTitle = new System.Windows.Forms.ToolStripLabel();
            this.txtBox_FinderField = new System.Windows.Forms.ToolStripTextBox();
            this.btn_ClearFinder = new System.Windows.Forms.ToolStripButton();
            this.dgv_SEC_USERS = new System.Windows.Forms.DataGridView();
            this.bs_SEC_USER = new System.Windows.Forms.BindingSource(this.components);
            this.dts_SEC_USERS = new SECURITY_USERS.dtsSEC_USERS();
            this.sECUSERFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEC_USER_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ts_HeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_HeaderButtons
            // 
            this.ts_HeaderButtons.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_HeaderButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNewUser,
            this.btn_AddNewUserWithCopy,
            this.btn_EditUset,
            this.btn_RemoveUser,
            this.sep_ButtonsToFinder,
            this.lbl_FinderTitle,
            this.txtBox_FinderField,
            this.btn_ClearFinder});
            this.ts_HeaderButtons.Location = new System.Drawing.Point(0, 0);
            this.ts_HeaderButtons.Name = "ts_HeaderButtons";
            this.ts_HeaderButtons.Size = new System.Drawing.Size(913, 39);
            this.ts_HeaderButtons.TabIndex = 0;
            this.ts_HeaderButtons.Text = "toolStrip1";
            // 
            // btn_AddNewUser
            // 
            this.btn_AddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewUser.Image = global::SECURITY_USERS.Properties.Resources.addButton;
            this.btn_AddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewUser.Name = "btn_AddNewUser";
            this.btn_AddNewUser.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewUser.Text = "Добавление нового пользователя";
            // 
            // btn_AddNewUserWithCopy
            // 
            this.btn_AddNewUserWithCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewUserWithCopy.Image = global::SECURITY_USERS.Properties.Resources.copyButton;
            this.btn_AddNewUserWithCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewUserWithCopy.Name = "btn_AddNewUserWithCopy";
            this.btn_AddNewUserWithCopy.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewUserWithCopy.Text = "Создать нового пользователя на основе копии";
            // 
            // btn_EditUset
            // 
            this.btn_EditUset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditUset.Image = global::SECURITY_USERS.Properties.Resources.editButton;
            this.btn_EditUset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditUset.Name = "btn_EditUset";
            this.btn_EditUset.Size = new System.Drawing.Size(36, 36);
            this.btn_EditUset.Text = "Редактировать данные пользователя";
            // 
            // btn_RemoveUser
            // 
            this.btn_RemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RemoveUser.Image = global::SECURITY_USERS.Properties.Resources.removeButton;
            this.btn_RemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RemoveUser.Name = "btn_RemoveUser";
            this.btn_RemoveUser.Size = new System.Drawing.Size(36, 36);
            this.btn_RemoveUser.Text = "Удалить пользователя";
            // 
            // sep_ButtonsToFinder
            // 
            this.sep_ButtonsToFinder.Name = "sep_ButtonsToFinder";
            this.sep_ButtonsToFinder.Size = new System.Drawing.Size(6, 39);
            // 
            // lbl_FinderTitle
            // 
            this.lbl_FinderTitle.Name = "lbl_FinderTitle";
            this.lbl_FinderTitle.Size = new System.Drawing.Size(42, 36);
            this.lbl_FinderTitle.Text = "Поиск";
            // 
            // txtBox_FinderField
            // 
            this.txtBox_FinderField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_FinderField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_FinderField.Name = "txtBox_FinderField";
            this.txtBox_FinderField.Size = new System.Drawing.Size(400, 39);
            // 
            // btn_ClearFinder
            // 
            this.btn_ClearFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ClearFinder.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearFinder.Image")));
            this.btn_ClearFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ClearFinder.Name = "btn_ClearFinder";
            this.btn_ClearFinder.Size = new System.Drawing.Size(23, 36);
            this.btn_ClearFinder.Text = "X";
            this.btn_ClearFinder.ToolTipText = "Очистить поле поиска";
            // 
            // dgv_SEC_USERS
            // 
            this.dgv_SEC_USERS.AllowUserToAddRows = false;
            this.dgv_SEC_USERS.AllowUserToResizeRows = false;
            this.dgv_SEC_USERS.AutoGenerateColumns = false;
            this.dgv_SEC_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SEC_USERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECUSERFIODataGridViewTextBoxColumn,
            this.sECUSERLOGINDataGridViewTextBoxColumn,
            this.SEC_USER_TYPE,
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn});
            this.dgv_SEC_USERS.DataSource = this.bs_SEC_USER;
            this.dgv_SEC_USERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SEC_USERS.Location = new System.Drawing.Point(0, 39);
            this.dgv_SEC_USERS.Name = "dgv_SEC_USERS";
            this.dgv_SEC_USERS.ReadOnly = true;
            this.dgv_SEC_USERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SEC_USERS.Size = new System.Drawing.Size(913, 326);
            this.dgv_SEC_USERS.TabIndex = 1;
            // 
            // bs_SEC_USER
            // 
            this.bs_SEC_USER.DataMember = "SEC_USER";
            this.bs_SEC_USER.DataSource = this.dts_SEC_USERS;
            // 
            // dts_SEC_USERS
            // 
            this.dts_SEC_USERS.DataSetName = "dtsSEC_USERS";
            this.dts_SEC_USERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sECUSERFIODataGridViewTextBoxColumn
            // 
            this.sECUSERFIODataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_FIO";
            this.sECUSERFIODataGridViewTextBoxColumn.HeaderText = "Фамилия Имя Отчество";
            this.sECUSERFIODataGridViewTextBoxColumn.Name = "sECUSERFIODataGridViewTextBoxColumn";
            this.sECUSERFIODataGridViewTextBoxColumn.Width = 250;
            // 
            // sECUSERLOGINDataGridViewTextBoxColumn
            // 
            this.sECUSERLOGINDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_LOGIN";
            this.sECUSERLOGINDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.sECUSERLOGINDataGridViewTextBoxColumn.Name = "sECUSERLOGINDataGridViewTextBoxColumn";
            this.sECUSERLOGINDataGridViewTextBoxColumn.Width = 250;
            // 
            // SEC_USER_TYPE
            // 
            this.SEC_USER_TYPE.DataSource = this.bs_SEC_USER;
            this.SEC_USER_TYPE.HeaderText = "Тип пользователя";
            this.SEC_USER_TYPE.Name = "SEC_USER_TYPE";
            this.SEC_USER_TYPE.ValueMember = "SEC_USER_TYPE_ID";
            this.SEC_USER_TYPE.Width = 200;
            // 
            // sECUSERDISABLEDDataGridViewCheckBoxColumn
            // 
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.DataPropertyName = "SEC_USER_DISABLED";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.HeaderText = "Заблокирован";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.Name = "sECUSERDISABLEDDataGridViewCheckBoxColumn";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 365);
            this.Controls.Add(this.dgv_SEC_USERS);
            this.Controls.Add(this.ts_HeaderButtons);
            this.Name = "Users";
            this.Text = "Пользователи";
            this.ts_HeaderButtons.ResumeLayout(false);
            this.ts_HeaderButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_HeaderButtons;
        private System.Windows.Forms.BindingSource bs_SEC_USER;
        private SECURITY_USERS.dtsSEC_USERS dts_SEC_USERS;
        private System.Windows.Forms.DataGridView dgv_SEC_USERS;
        private System.Windows.Forms.ToolStripButton btn_AddNewUser;
        private System.Windows.Forms.ToolStripButton btn_AddNewUserWithCopy;
        private System.Windows.Forms.ToolStripButton btn_EditUset;
        private System.Windows.Forms.ToolStripButton btn_RemoveUser;
        private System.Windows.Forms.ToolStripSeparator sep_ButtonsToFinder;
        private System.Windows.Forms.ToolStripLabel lbl_FinderTitle;
        private System.Windows.Forms.ToolStripTextBox txtBox_FinderField;
        private System.Windows.Forms.ToolStripButton btn_ClearFinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SEC_USER_TYPE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sECUSERDISABLEDDataGridViewCheckBoxColumn;
    }
}


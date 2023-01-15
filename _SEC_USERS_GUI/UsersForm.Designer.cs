
namespace _SEC_USERS_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts_HeaderButtons = new System.Windows.Forms.ToolStrip();
            this.btn_AddNewUser = new System.Windows.Forms.ToolStripButton();
            this.btn_AddNewUserWithCopy = new System.Windows.Forms.ToolStripButton();
            this.btn_EditUser = new System.Windows.Forms.ToolStripButton();
            this.btn_RemoveUser = new System.Windows.Forms.ToolStripButton();
            this.sep_ButtonsToFinder = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_FinderTitle = new System.Windows.Forms.ToolStripLabel();
            this.txtBox_FinderField = new System.Windows.Forms.ToolStripTextBox();
            this.btn_ClearFinder = new System.Windows.Forms.ToolStripButton();
            this.dgv_SEC_USERS = new System.Windows.Forms.DataGridView();
            this.sECUSERFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEC_USER_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs_SEC_USER_TYPE = new System.Windows.Forms.BindingSource(this.components);
            this.dts_SEC_USERS = new _SEC_USERS.dtsSEC_USERS();
            this.SEC_ROLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bs_SEC_USERS = new System.Windows.Forms.BindingSource(this.components);
            this.ts_HeaderButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USERS)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_HeaderButtons
            // 
            this.ts_HeaderButtons.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_HeaderButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddNewUser,
            this.btn_AddNewUserWithCopy,
            this.btn_EditUser,
            this.btn_RemoveUser,
            this.sep_ButtonsToFinder,
            this.lbl_FinderTitle,
            this.txtBox_FinderField,
            this.btn_ClearFinder});
            this.ts_HeaderButtons.Location = new System.Drawing.Point(0, 0);
            this.ts_HeaderButtons.Name = "ts_HeaderButtons";
            this.ts_HeaderButtons.Size = new System.Drawing.Size(1409, 39);
            this.ts_HeaderButtons.TabIndex = 0;
            this.ts_HeaderButtons.Text = "toolStrip1";
            // 
            // btn_AddNewUser
            // 
            this.btn_AddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewUser.Image = global::_SEC_USERS_GUI.Properties.Resources.addButton;
            this.btn_AddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewUser.Name = "btn_AddNewUser";
            this.btn_AddNewUser.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewUser.Text = "Добавление нового пользователя";
            this.btn_AddNewUser.Click += new System.EventHandler(this.btn_AddNewUser_Click);
            // 
            // btn_AddNewUserWithCopy
            // 
            this.btn_AddNewUserWithCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddNewUserWithCopy.Image = global::_SEC_USERS_GUI.Properties.Resources.copyButton;
            this.btn_AddNewUserWithCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddNewUserWithCopy.Name = "btn_AddNewUserWithCopy";
            this.btn_AddNewUserWithCopy.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewUserWithCopy.Text = "Создать нового пользователя на основе копии";
            this.btn_AddNewUserWithCopy.Click += new System.EventHandler(this.btn_AddNewUserWithCopy_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EditUser.Image = global::_SEC_USERS_GUI.Properties.Resources.editButton;
            this.btn_EditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(36, 36);
            this.btn_EditUser.Text = "Редактировать данные пользователя";
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_RemoveUser
            // 
            this.btn_RemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RemoveUser.Image = global::_SEC_USERS_GUI.Properties.Resources.removeButton;
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
            this.lbl_FinderTitle.Size = new System.Drawing.Size(52, 36);
            this.lbl_FinderTitle.Text = "Поиск";
            // 
            // txtBox_FinderField
            // 
            this.txtBox_FinderField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_FinderField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBox_FinderField.Name = "txtBox_FinderField";
            this.txtBox_FinderField.Size = new System.Drawing.Size(533, 39);
            this.txtBox_FinderField.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btn_ClearFinder
            // 
            this.btn_ClearFinder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ClearFinder.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearFinder.Image")));
            this.btn_ClearFinder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ClearFinder.Name = "btn_ClearFinder";
            this.btn_ClearFinder.Size = new System.Drawing.Size(29, 36);
            this.btn_ClearFinder.Text = "X";
            this.btn_ClearFinder.ToolTipText = "Очистить поле поиска";
            this.btn_ClearFinder.Click += new System.EventHandler(this.btn_ClearFinder_Click);
            // 
            // dgv_SEC_USERS
            // 
            this.dgv_SEC_USERS.AllowUserToAddRows = false;
            this.dgv_SEC_USERS.AllowUserToDeleteRows = false;
            this.dgv_SEC_USERS.AllowUserToResizeRows = false;
            this.dgv_SEC_USERS.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_SEC_USERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SEC_USERS.ColumnHeadersHeight = 31;
            this.dgv_SEC_USERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_SEC_USERS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECUSERFIODataGridViewTextBoxColumn,
            this.sECUSERLOGINDataGridViewTextBoxColumn,
            this.SEC_USER_TYPE,
            this.SEC_ROLES,
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn});
            this.dgv_SEC_USERS.DataSource = this.bs_SEC_USERS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SEC_USERS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SEC_USERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SEC_USERS.Location = new System.Drawing.Point(0, 39);
            this.dgv_SEC_USERS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_SEC_USERS.Name = "dgv_SEC_USERS";
            this.dgv_SEC_USERS.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgv_SEC_USERS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SEC_USERS.RowHeadersWidth = 51;
            this.dgv_SEC_USERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SEC_USERS.Size = new System.Drawing.Size(1409, 653);
            this.dgv_SEC_USERS.TabIndex = 1;
            // 
            // sECUSERFIODataGridViewTextBoxColumn
            // 
            this.sECUSERFIODataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_FIO";
            this.sECUSERFIODataGridViewTextBoxColumn.HeaderText = "Фамилия Имя Отчество";
            this.sECUSERFIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sECUSERFIODataGridViewTextBoxColumn.Name = "sECUSERFIODataGridViewTextBoxColumn";
            this.sECUSERFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.sECUSERFIODataGridViewTextBoxColumn.Width = 200;
            // 
            // sECUSERLOGINDataGridViewTextBoxColumn
            // 
            this.sECUSERLOGINDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_LOGIN";
            this.sECUSERLOGINDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.sECUSERLOGINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sECUSERLOGINDataGridViewTextBoxColumn.Name = "sECUSERLOGINDataGridViewTextBoxColumn";
            this.sECUSERLOGINDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECUSERLOGINDataGridViewTextBoxColumn.Width = 150;
            // 
            // SEC_USER_TYPE
            // 
            this.SEC_USER_TYPE.DataPropertyName = "SEC_USER_TYPE_ID";
            this.SEC_USER_TYPE.DataSource = this.bs_SEC_USER_TYPE;
            this.SEC_USER_TYPE.DisplayMember = "SEC_USER_TYPE_NAME";
            this.SEC_USER_TYPE.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SEC_USER_TYPE.HeaderText = "Тип пользователя";
            this.SEC_USER_TYPE.MinimumWidth = 6;
            this.SEC_USER_TYPE.Name = "SEC_USER_TYPE";
            this.SEC_USER_TYPE.ReadOnly = true;
            this.SEC_USER_TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SEC_USER_TYPE.ValueMember = "SEC_USER_TYPE_ID";
            this.SEC_USER_TYPE.Width = 120;
            // 
            // bs_SEC_USER_TYPE
            // 
            this.bs_SEC_USER_TYPE.DataMember = "SEC_USER_TYPE";
            this.bs_SEC_USER_TYPE.DataSource = this.dts_SEC_USERS;
            // 
            // dts_SEC_USERS
            // 
            this.dts_SEC_USERS.DataSetName = "dtsSEC_USERS";
            this.dts_SEC_USERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SEC_ROLES
            // 
            this.SEC_ROLES.DataPropertyName = "SEC_ROLES";
            this.SEC_ROLES.HeaderText = "Роли";
            this.SEC_ROLES.MinimumWidth = 6;
            this.SEC_ROLES.Name = "SEC_ROLES";
            this.SEC_ROLES.ReadOnly = true;
            this.SEC_ROLES.Width = 300;
            // 
            // sECUSERDISABLEDDataGridViewCheckBoxColumn
            // 
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.DataPropertyName = "SEC_USER_DISABLED";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.HeaderText = "Заблокирован";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.Name = "sECUSERDISABLEDDataGridViewCheckBoxColumn";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bs_SEC_USERS
            // 
            this.bs_SEC_USERS.DataMember = "SEC_USER";
            this.bs_SEC_USERS.DataSource = this.dts_SEC_USERS;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 692);
            this.Controls.Add(this.dgv_SEC_USERS);
            this.Controls.Add(this.ts_HeaderButtons);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            this.ts_HeaderButtons.ResumeLayout(false);
            this.ts_HeaderButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_HeaderButtons;
        private System.Windows.Forms.BindingSource bs_SEC_USERS;
        private System.Windows.Forms.BindingSource bs_SEC_USER_TYPE;
        private _SEC_USERS.dtsSEC_USERS dts_SEC_USERS;
        private System.Windows.Forms.DataGridView dgv_SEC_USERS;
        private System.Windows.Forms.ToolStripButton btn_AddNewUser;
        private System.Windows.Forms.ToolStripButton btn_AddNewUserWithCopy;
        private System.Windows.Forms.ToolStripButton btn_EditUser;
        private System.Windows.Forms.ToolStripButton btn_RemoveUser;
        private System.Windows.Forms.ToolStripSeparator sep_ButtonsToFinder;
        private System.Windows.Forms.ToolStripLabel lbl_FinderTitle;
        private System.Windows.Forms.ToolStripTextBox txtBox_FinderField;
        private System.Windows.Forms.ToolStripButton btn_ClearFinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SEC_USER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEC_ROLES;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sECUSERDISABLEDDataGridViewCheckBoxColumn;
    }
}


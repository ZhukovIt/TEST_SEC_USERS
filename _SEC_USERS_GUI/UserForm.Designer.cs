
namespace _SEC_USERS_GUI
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dts_SEC_USERS = new _SEC_USERS.dtsSEC_USERS();
            this.bs_SEC_USER = new System.Windows.Forms.BindingSource(this.components);
            this.bs_SEC_USER_TYPE = new System.Windows.Forms.BindingSource(this.components);
            this.TLP_UserInfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxIsDisabled = new System.Windows.Forms.CheckBox();
            this.lbl_UserLogin = new System.Windows.Forms.Label();
            this.lbl_userTypeId = new System.Windows.Forms.Label();
            this.lbl_UserFIO = new System.Windows.Forms.Label();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.checkBoxNoCheck = new System.Windows.Forms.CheckBox();
            this.comboBox_TypeUser = new System.Windows.Forms.ComboBox();
            this.checkBoxBuiltIn = new System.Windows.Forms.CheckBox();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SaveExecute = new System.Windows.Forms.Button();
            this.btn_CancelExecute = new System.Windows.Forms.Button();
            this.dataGridView_Roles = new System.Windows.Forms.DataGridView();
            this.sECROLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddNewRole = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_DeleteRole = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).BeginInit();
            this.TLP_UserInfoContainer.SuspendLayout();
            this.TLP_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Roles)).BeginInit();
            this.SuspendLayout();
            // 
            // dts_SEC_USERS
            // 
            this.dts_SEC_USERS.DataSetName = "dtsSEC_USERS";
            this.dts_SEC_USERS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_SEC_USER
            // 
            this.bs_SEC_USER.DataMember = "SEC_ROLE";
            this.bs_SEC_USER.DataSource = this.dts_SEC_USERS;
            // 
            // bs_SEC_USER_TYPE
            // 
            this.bs_SEC_USER_TYPE.DataMember = "SEC_USER_TYPE";
            this.bs_SEC_USER_TYPE.DataSource = this.dts_SEC_USERS;
            // 
            // TLP_UserInfoContainer
            // 
            this.TLP_UserInfoContainer.ColumnCount = 2;
            this.TLP_UserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_UserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxIsDisabled, 0, 4);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_UserLogin, 0, 1);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_userTypeId, 0, 2);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_UserFIO, 0, 0);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox_FIO, 1, 0);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox_Login, 1, 1);
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxNoCheck, 0, 5);
            this.TLP_UserInfoContainer.Controls.Add(this.comboBox_TypeUser, 1, 2);
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxBuiltIn, 0, 3);
            this.TLP_UserInfoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLP_UserInfoContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TLP_UserInfoContainer.Location = new System.Drawing.Point(0, 0);
            this.TLP_UserInfoContainer.Name = "TLP_UserInfoContainer";
            this.TLP_UserInfoContainer.RowCount = 6;
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.669F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.669F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.669F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.662F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.662F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.669F));
            this.TLP_UserInfoContainer.Size = new System.Drawing.Size(436, 320);
            this.TLP_UserInfoContainer.TabIndex = 0;
            // 
            // checkBoxIsDisabled
            // 
            this.checkBoxIsDisabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxIsDisabled.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxIsDisabled, 2);
            this.checkBoxIsDisabled.Location = new System.Drawing.Point(131, 230);
            this.checkBoxIsDisabled.Name = "checkBoxIsDisabled";
            this.checkBoxIsDisabled.Size = new System.Drawing.Size(174, 17);
            this.checkBoxIsDisabled.TabIndex = 3;
            this.checkBoxIsDisabled.Text = "Пользователь заблокирован";
            this.checkBoxIsDisabled.UseVisualStyleBackColor = true;
            // 
            // lbl_UserLogin
            // 
            this.lbl_UserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserLogin.AutoSize = true;
            this.lbl_UserLogin.Location = new System.Drawing.Point(15, 73);
            this.lbl_UserLogin.Name = "lbl_UserLogin";
            this.lbl_UserLogin.Size = new System.Drawing.Size(112, 13);
            this.lbl_UserLogin.TabIndex = 1;
            this.lbl_UserLogin.Text = "Логин пользователя";
            // 
            // lbl_userTypeId
            // 
            this.lbl_userTypeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userTypeId.AutoSize = true;
            this.lbl_userTypeId.Location = new System.Drawing.Point(21, 126);
            this.lbl_userTypeId.Name = "lbl_userTypeId";
            this.lbl_userTypeId.Size = new System.Drawing.Size(100, 13);
            this.lbl_userTypeId.TabIndex = 5;
            this.lbl_userTypeId.Text = "Тип пользователя";
            // 
            // lbl_UserFIO
            // 
            this.lbl_UserFIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_UserFIO.AutoSize = true;
            this.lbl_UserFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_UserFIO.Location = new System.Drawing.Point(3, 20);
            this.lbl_UserFIO.Name = "lbl_UserFIO";
            this.lbl_UserFIO.Size = new System.Drawing.Size(137, 13);
            this.lbl_UserFIO.TabIndex = 0;
            this.lbl_UserFIO.Text = "Фамилия, Имя, Отчество";
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FIO.Location = new System.Drawing.Point(176, 16);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(226, 20);
            this.textBox_FIO.TabIndex = 6;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Login.Location = new System.Drawing.Point(176, 69);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(226, 20);
            this.textBox_Login.TabIndex = 7;
            // 
            // checkBoxNoCheck
            // 
            this.checkBoxNoCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxNoCheck.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxNoCheck, 2);
            this.checkBoxNoCheck.Location = new System.Drawing.Point(109, 284);
            this.checkBoxNoCheck.Name = "checkBoxNoCheck";
            this.checkBoxNoCheck.Size = new System.Drawing.Size(218, 17);
            this.checkBoxNoCheck.TabIndex = 10;
            this.checkBoxNoCheck.Text = "Не выполнять проверку прав доступа";
            this.checkBoxNoCheck.UseVisualStyleBackColor = true;
            // 
            // comboBox_TypeUser
            // 
            this.comboBox_TypeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TypeUser.DataSource = this.bs_SEC_USER_TYPE;
            this.comboBox_TypeUser.DisplayMember = "SEC_USER_TYPE_NAME";
            this.comboBox_TypeUser.FormattingEnabled = true;
            this.comboBox_TypeUser.Location = new System.Drawing.Point(176, 122);
            this.comboBox_TypeUser.Name = "comboBox_TypeUser";
            this.comboBox_TypeUser.Size = new System.Drawing.Size(226, 21);
            this.comboBox_TypeUser.TabIndex = 11;
            this.comboBox_TypeUser.ValueMember = "SEC_USER_TYPE_NAME";
            // 
            // checkBoxBuiltIn
            // 
            this.checkBoxBuiltIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxBuiltIn.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxBuiltIn, 2);
            this.checkBoxBuiltIn.Location = new System.Drawing.Point(96, 177);
            this.checkBoxBuiltIn.Name = "checkBoxBuiltIn";
            this.checkBoxBuiltIn.Size = new System.Drawing.Size(244, 17);
            this.checkBoxBuiltIn.TabIndex = 8;
            this.checkBoxBuiltIn.Text = "Пользователь является администратором";
            this.checkBoxBuiltIn.UseVisualStyleBackColor = true;
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 2;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Controls.Add(this.btn_SaveExecute, 0, 0);
            this.TLP_Buttons.Controls.Add(this.btn_CancelExecute, 1, 0);
            this.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLP_Buttons.Location = new System.Drawing.Point(0, 509);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 1;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Size = new System.Drawing.Size(436, 57);
            this.TLP_Buttons.TabIndex = 2;
            // 
            // btn_SaveExecute
            // 
            this.btn_SaveExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SaveExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SaveExecute.Location = new System.Drawing.Point(64, 14);
            this.btn_SaveExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveExecute.Name = "btn_SaveExecute";
            this.btn_SaveExecute.Size = new System.Drawing.Size(90, 28);
            this.btn_SaveExecute.TabIndex = 0;
            this.btn_SaveExecute.Text = "Сохранить";
            this.btn_SaveExecute.UseVisualStyleBackColor = true;
            // 
            // btn_CancelExecute
            // 
            this.btn_CancelExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CancelExecute.Location = new System.Drawing.Point(282, 14);
            this.btn_CancelExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancelExecute.Name = "btn_CancelExecute";
            this.btn_CancelExecute.Size = new System.Drawing.Size(90, 28);
            this.btn_CancelExecute.TabIndex = 0;
            this.btn_CancelExecute.Text = "Отмена";
            this.btn_CancelExecute.UseVisualStyleBackColor = true;
            this.btn_CancelExecute.Click += new System.EventHandler(this.btn_CancelExecute_Click);
            // 
            // dataGridView_Roles
            // 
            this.dataGridView_Roles.AutoGenerateColumns = false;
            this.dataGridView_Roles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Roles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECROLENAMEDataGridViewTextBoxColumn,
            this.btn_AddNewRole,
            this.btn_DeleteRole});
            this.dataGridView_Roles.DataSource = this.bs_SEC_USER;
            this.dataGridView_Roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Roles.Location = new System.Drawing.Point(0, 320);
            this.dataGridView_Roles.Name = "dataGridView_Roles";
            this.dataGridView_Roles.RowHeadersWidth = 51;
            this.dataGridView_Roles.Size = new System.Drawing.Size(436, 189);
            this.dataGridView_Roles.TabIndex = 1;
            // 
            // sECROLENAMEDataGridViewTextBoxColumn
            // 
            this.sECROLENAMEDataGridViewTextBoxColumn.DataPropertyName = "SEC_ROLE_NAME";
            this.sECROLENAMEDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.sECROLENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sECROLENAMEDataGridViewTextBoxColumn.Name = "sECROLENAMEDataGridViewTextBoxColumn";
            this.sECROLENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // btn_AddNewRole
            // 
            this.btn_AddNewRole.HeaderText = "";
            this.btn_AddNewRole.MinimumWidth = 6;
            this.btn_AddNewRole.Name = "btn_AddNewRole";
            this.btn_AddNewRole.Width = 32;
            // 
            // btn_DeleteRole
            // 
            this.btn_DeleteRole.HeaderText = "";
            this.btn_DeleteRole.MinimumWidth = 6;
            this.btn_DeleteRole.Name = "btn_DeleteRole";
            this.btn_DeleteRole.Width = 32;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 566);
            this.Controls.Add(this.TLP_Buttons);
            this.Controls.Add(this.dataGridView_Roles);
            this.Controls.Add(this.TLP_UserInfoContainer);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).EndInit();
            this.TLP_UserInfoContainer.ResumeLayout(false);
            this.TLP_UserInfoContainer.PerformLayout();
            this.TLP_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_SEC_USER;
        private System.Windows.Forms.BindingSource bs_SEC_USER_TYPE;
        private _SEC_USERS.dtsSEC_USERS dts_SEC_USERS;
        private System.Windows.Forms.TableLayoutPanel TLP_UserInfoContainer;
        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private System.Windows.Forms.Label lbl_UserLogin;
        private System.Windows.Forms.Label lbl_userTypeId;
        private System.Windows.Forms.Label lbl_UserFIO;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.CheckBox checkBoxBuiltIn;
        private System.Windows.Forms.CheckBox checkBoxNoCheck;
        private System.Windows.Forms.ComboBox comboBox_TypeUser;
        private System.Windows.Forms.DataGridView dataGridView_Roles;
        private System.Windows.Forms.CheckBox checkBoxIsDisabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECROLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btn_AddNewRole;
        private System.Windows.Forms.DataGridViewButtonColumn btn_DeleteRole;
        private System.Windows.Forms.Button btn_SaveExecute;
        private System.Windows.Forms.Button btn_CancelExecute;


        // Здесь добавлены свойства для доступа к элементам GUI

        public System.Windows.Forms.Button GetButtonSaveExecute
        {
            get
            {
                return btn_SaveExecute;
            }
        }

        public System.Windows.Forms.TextBox GetFIOTextBox
        {
            get
            {
                return textBox_FIO;
            }
        }

        public System.Windows.Forms.TextBox GetLoginTextBox
        {
            get
            {
                return textBox_Login;
            }
        }

        public System.Windows.Forms.ComboBox GetUserTypeComboBox
        {
            get
            {
                return comboBox_TypeUser;
            }
        }

        public System.Windows.Forms.CheckBox GetBuiltInCheckBox
        {
            get
            {
                return checkBoxBuiltIn;
            }
        }

        public System.Windows.Forms.CheckBox GetIsDisabledCheckBox
        {
            get
            {
                return checkBoxIsDisabled;
            }
        }

        public System.Windows.Forms.CheckBox GetNoCheckCheckBox
        {
            get
            {
                return checkBoxNoCheck;
            }
        }
    }
}
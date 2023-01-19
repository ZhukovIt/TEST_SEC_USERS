
using Model;

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
            this.bs_SEC_USER = new System.Windows.Forms.BindingSource(this.components);
            this.dts_SEC_USERS = new _SEC_USERS.dtsSEC_USERS();
            this.bs_SEC_ROLE = new System.Windows.Forms.BindingSource(this.components);
            this.bs_SEC_USER_TYPE = new System.Windows.Forms.BindingSource(this.components);
            this.bs_SEC_USER_FROM_SEC_ROLES = new System.Windows.Forms.BindingSource(this.components);
            this.bs_WORKER = new System.Windows.Forms.BindingSource(this.components);
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
            this.lbl_WorkUser = new System.Windows.Forms.Label();
            this.comboBox_WORKER_FULL_NAME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SaveExecute = new System.Windows.Forms.Button();
            this.btn_CancelExecute = new System.Windows.Forms.Button();
            this.dataGridView_Roles = new System.Windows.Forms.DataGridView();
            this.RoleName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ButtonInDataGrid_AddNewRole = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonInDataGrid_RemoveRole = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sECROLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_ROLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_FROM_SEC_ROLES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_WORKER)).BeginInit();
            this.TLP_UserInfoContainer.SuspendLayout();
            this.TLP_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Roles)).BeginInit();
            this.SuspendLayout();
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
            // bs_SEC_ROLE
            // 
            this.bs_SEC_ROLE.DataMember = "SEC_ROLE";
            this.bs_SEC_ROLE.DataSource = this.dts_SEC_USERS;
            // 
            // bs_SEC_USER_TYPE
            // 
            this.bs_SEC_USER_TYPE.DataMember = "SEC_USER_TYPE";
            this.bs_SEC_USER_TYPE.DataSource = this.dts_SEC_USERS;
            // 
            // bs_SEC_USER_FROM_SEC_ROLES
            // 
            this.bs_SEC_USER_FROM_SEC_ROLES.DataMember = "FK_SEC_USER_SEC_USER__SEC_USER";
            this.bs_SEC_USER_FROM_SEC_ROLES.DataSource = this.bs_SEC_USER;
            // 
            // bs_WORKER
            // 
            this.bs_WORKER.DataMember = "WORKER";
            this.bs_WORKER.DataSource = this.dts_SEC_USERS;
            // 
            // TLP_UserInfoContainer
            // 
            this.TLP_UserInfoContainer.ColumnCount = 2;
            this.TLP_UserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLP_UserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxIsDisabled, 0, 5);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_UserLogin, 0, 1);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_userTypeId, 0, 2);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_UserFIO, 0, 0);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox_FIO, 1, 0);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox_Login, 1, 1);
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxNoCheck, 0, 6);
            this.TLP_UserInfoContainer.Controls.Add(this.comboBox_TypeUser, 1, 2);
            this.TLP_UserInfoContainer.Controls.Add(this.checkBoxBuiltIn, 0, 4);
            this.TLP_UserInfoContainer.Controls.Add(this.lbl_WorkUser, 0, 3);
            this.TLP_UserInfoContainer.Controls.Add(this.comboBox_WORKER_FULL_NAME, 1, 3);
            this.TLP_UserInfoContainer.Controls.Add(this.label1, 0, 7);
            this.TLP_UserInfoContainer.Controls.Add(this.label2, 0, 8);
            this.TLP_UserInfoContainer.Controls.Add(this.label3, 0, 9);
            this.TLP_UserInfoContainer.Controls.Add(this.label4, 0, 10);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox1, 1, 7);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox2, 1, 8);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox3, 1, 9);
            this.TLP_UserInfoContainer.Controls.Add(this.textBox4, 1, 10);
            this.TLP_UserInfoContainer.Controls.Add(this.label5, 0, 11);
            this.TLP_UserInfoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TLP_UserInfoContainer.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TLP_UserInfoContainer.Location = new System.Drawing.Point(0, 0);
            this.TLP_UserInfoContainer.Name = "TLP_UserInfoContainer";
            this.TLP_UserInfoContainer.RowCount = 12;
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.TLP_UserInfoContainer.Size = new System.Drawing.Size(436, 443);
            this.TLP_UserInfoContainer.TabIndex = 0;
            // 
            // checkBoxIsDisabled
            // 
            this.checkBoxIsDisabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxIsDisabled.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxIsDisabled, 2);
            this.checkBoxIsDisabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_SEC_USER, "SEC_USER_DISABLED", true));
            this.checkBoxIsDisabled.Location = new System.Drawing.Point(131, 189);
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
            this.lbl_UserLogin.Location = new System.Drawing.Point(31, 47);
            this.lbl_UserLogin.Name = "lbl_UserLogin";
            this.lbl_UserLogin.Size = new System.Drawing.Size(112, 13);
            this.lbl_UserLogin.TabIndex = 1;
            this.lbl_UserLogin.Text = "Логин пользователя";
            // 
            // lbl_userTypeId
            // 
            this.lbl_userTypeId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userTypeId.AutoSize = true;
            this.lbl_userTypeId.Location = new System.Drawing.Point(37, 83);
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
            this.lbl_UserFIO.Location = new System.Drawing.Point(18, 11);
            this.lbl_UserFIO.Name = "lbl_UserFIO";
            this.lbl_UserFIO.Size = new System.Drawing.Size(137, 13);
            this.lbl_UserFIO.TabIndex = 0;
            this.lbl_UserFIO.Text = "Фамилия, Имя, Отчество";
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_FIO", true));
            this.textBox_FIO.Location = new System.Drawing.Point(192, 8);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(226, 20);
            this.textBox_FIO.TabIndex = 6;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Login.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_LOGIN", true));
            this.textBox_Login.Location = new System.Drawing.Point(192, 44);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(226, 20);
            this.textBox_Login.TabIndex = 7;
            // 
            // checkBoxNoCheck
            // 
            this.checkBoxNoCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxNoCheck.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxNoCheck, 2);
            this.checkBoxNoCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_SEC_USER, "SEC_USER_NO_CHECK", true));
            this.checkBoxNoCheck.Location = new System.Drawing.Point(109, 225);
            this.checkBoxNoCheck.Name = "checkBoxNoCheck";
            this.checkBoxNoCheck.Size = new System.Drawing.Size(218, 17);
            this.checkBoxNoCheck.TabIndex = 10;
            this.checkBoxNoCheck.Text = "Не выполнять проверку прав доступа";
            this.checkBoxNoCheck.UseVisualStyleBackColor = true;
            // 
            // comboBox_TypeUser
            // 
            this.comboBox_TypeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TypeUser.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_SEC_USER, "SEC_USER_TYPE_ID", true));
            this.comboBox_TypeUser.DataSource = this.bs_SEC_USER_TYPE;
            this.comboBox_TypeUser.DisplayMember = "SEC_USER_TYPE_NAME";
            this.comboBox_TypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeUser.FormattingEnabled = true;
            this.comboBox_TypeUser.Location = new System.Drawing.Point(192, 79);
            this.comboBox_TypeUser.Name = "comboBox_TypeUser";
            this.comboBox_TypeUser.Size = new System.Drawing.Size(226, 21);
            this.comboBox_TypeUser.TabIndex = 11;
            this.comboBox_TypeUser.ValueMember = "SEC_USER_TYPE_ID";
            // 
            // checkBoxBuiltIn
            // 
            this.checkBoxBuiltIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxBuiltIn.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.checkBoxBuiltIn, 2);
            this.checkBoxBuiltIn.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bs_SEC_USER, "SEC_USER_BUILTIN", true));
            this.checkBoxBuiltIn.Location = new System.Drawing.Point(96, 153);
            this.checkBoxBuiltIn.Name = "checkBoxBuiltIn";
            this.checkBoxBuiltIn.Size = new System.Drawing.Size(244, 17);
            this.checkBoxBuiltIn.TabIndex = 8;
            this.checkBoxBuiltIn.Text = "Пользователь является администратором";
            this.checkBoxBuiltIn.UseVisualStyleBackColor = true;
            // 
            // lbl_WorkUser
            // 
            this.lbl_WorkUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_WorkUser.AutoSize = true;
            this.lbl_WorkUser.Location = new System.Drawing.Point(57, 119);
            this.lbl_WorkUser.Name = "lbl_WorkUser";
            this.lbl_WorkUser.Size = new System.Drawing.Size(60, 13);
            this.lbl_WorkUser.TabIndex = 5;
            this.lbl_WorkUser.Text = "Сотрудник";
            // 
            // comboBox_WORKER_FULL_NAME
            // 
            this.comboBox_WORKER_FULL_NAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_WORKER_FULL_NAME.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bs_SEC_USER, "WORK_ID", true));
            this.comboBox_WORKER_FULL_NAME.DataSource = this.bs_WORKER;
            this.comboBox_WORKER_FULL_NAME.DisplayMember = "WORK_FULL_NAME";
            this.comboBox_WORKER_FULL_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_WORKER_FULL_NAME.FormattingEnabled = true;
            this.comboBox_WORKER_FULL_NAME.Location = new System.Drawing.Point(192, 115);
            this.comboBox_WORKER_FULL_NAME.Name = "comboBox_WORKER_FULL_NAME";
            this.comboBox_WORKER_FULL_NAME.Size = new System.Drawing.Size(226, 21);
            this.comboBox_WORKER_FULL_NAME.TabIndex = 11;
            this.comboBox_WORKER_FULL_NAME.ValueMember = "WORK_ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Право подписи документов";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пользователь для ККМ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль от ККМ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ИНН для ККМ";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_PROCURATORY", true));
            this.textBox1.Location = new System.Drawing.Point(192, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_KKM_LOGIN", true));
            this.textBox2.Location = new System.Drawing.Point(192, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_KKM_PASSWORD", true));
            this.textBox3.Location = new System.Drawing.Point(192, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_SEC_USER, "SEC_USER_KKM_INN", true));
            this.textBox4.Location = new System.Drawing.Point(192, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.TLP_UserInfoContainer.SetColumnSpan(this.label5, 2);
            this.label5.Location = new System.Drawing.Point(202, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Роли";
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 2;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Controls.Add(this.btn_SaveExecute, 0, 0);
            this.TLP_Buttons.Controls.Add(this.btn_CancelExecute, 1, 0);
            this.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLP_Buttons.Location = new System.Drawing.Point(0, 626);
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
            this.btn_SaveExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveExecute.Name = "btn_SaveExecute";
            this.btn_SaveExecute.Size = new System.Drawing.Size(90, 28);
            this.btn_SaveExecute.TabIndex = 0;
            this.btn_SaveExecute.Text = "Сохранить";
            this.btn_SaveExecute.UseVisualStyleBackColor = true;
            this.btn_SaveExecute.Click += new System.EventHandler(this.btn_SaveExecute_Click);
            // 
            // btn_CancelExecute
            // 
            this.btn_CancelExecute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CancelExecute.Location = new System.Drawing.Point(282, 14);
            this.btn_CancelExecute.Margin = new System.Windows.Forms.Padding(2);
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
            this.RoleName,
            this.ButtonInDataGrid_AddNewRole,
            this.ButtonInDataGrid_RemoveRole,
            this.sECROLEIDDataGridViewTextBoxColumn,
            this.sECUSERIDDataGridViewTextBoxColumn});
            this.dataGridView_Roles.DataSource = this.bs_SEC_USER_FROM_SEC_ROLES;
            this.dataGridView_Roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Roles.Location = new System.Drawing.Point(0, 443);
            this.dataGridView_Roles.Name = "dataGridView_Roles";
            this.dataGridView_Roles.Size = new System.Drawing.Size(436, 183);
            this.dataGridView_Roles.TabIndex = 3;
            this.dataGridView_Roles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Roles_CellMouseClick);
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "SEC_ROLE_ID";
            this.RoleName.DataSource = this.bs_SEC_ROLE;
            this.RoleName.DisplayMember = "SEC_ROLE_NAME";
            this.RoleName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.RoleName.HeaderText = "Наименование";
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RoleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RoleName.ValueMember = "SEC_ROLE_ID";
            this.RoleName.Width = 300;
            // 
            // ButtonInDataGrid_AddNewRole
            // 
            this.ButtonInDataGrid_AddNewRole.HeaderText = "";
            this.ButtonInDataGrid_AddNewRole.Name = "ButtonInDataGrid_AddNewRole";
            this.ButtonInDataGrid_AddNewRole.Text = "...";
            this.ButtonInDataGrid_AddNewRole.UseColumnTextForButtonValue = true;
            this.ButtonInDataGrid_AddNewRole.Width = 25;
            // 
            // ButtonInDataGrid_RemoveRole
            // 
            this.ButtonInDataGrid_RemoveRole.HeaderText = "";
            this.ButtonInDataGrid_RemoveRole.Name = "ButtonInDataGrid_RemoveRole";
            this.ButtonInDataGrid_RemoveRole.Text = "x";
            this.ButtonInDataGrid_RemoveRole.UseColumnTextForButtonValue = true;
            this.ButtonInDataGrid_RemoveRole.Width = 25;
            // 
            // sECROLEIDDataGridViewTextBoxColumn
            // 
            this.sECROLEIDDataGridViewTextBoxColumn.DataPropertyName = "SEC_ROLE_ID";
            this.sECROLEIDDataGridViewTextBoxColumn.HeaderText = "SEC_ROLE_ID";
            this.sECROLEIDDataGridViewTextBoxColumn.Name = "sECROLEIDDataGridViewTextBoxColumn";
            this.sECROLEIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sECUSERIDDataGridViewTextBoxColumn
            // 
            this.sECUSERIDDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_ID";
            this.sECUSERIDDataGridViewTextBoxColumn.HeaderText = "SEC_USER_ID";
            this.sECUSERIDDataGridViewTextBoxColumn.Name = "sECUSERIDDataGridViewTextBoxColumn";
            this.sECUSERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 683);
            this.Controls.Add(this.dataGridView_Roles);
            this.Controls.Add(this.TLP_Buttons);
            this.Controls.Add(this.TLP_UserInfoContainer);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dts_SEC_USERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_ROLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER_FROM_SEC_ROLES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_WORKER)).EndInit();
            this.TLP_UserInfoContainer.ResumeLayout(false);
            this.TLP_UserInfoContainer.PerformLayout();
            this.TLP_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Roles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_SEC_USER;
        private System.Windows.Forms.BindingSource bs_SEC_ROLE;
        private System.Windows.Forms.BindingSource bs_SEC_USER_TYPE;
        private System.Windows.Forms.BindingSource bs_SEC_USER_FROM_SEC_ROLES;
        private System.Windows.Forms.BindingSource bs_WORKER;
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
        private System.Windows.Forms.CheckBox checkBoxIsDisabled;
        private System.Windows.Forms.Button btn_SaveExecute;
        private System.Windows.Forms.Button btn_CancelExecute;
        private System.Windows.Forms.DataGridView dataGridView_Roles;
        private _SEC_USERS.dtsSEC_USERS dts_SEC_USERS;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonInDataGrid_AddNewRole;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonInDataGrid_RemoveRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECROLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_WorkUser;
        private System.Windows.Forms.ComboBox comboBox_WORKER_FULL_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;


        // Здесь добавлены свойства для доступа к элементам GUI

        public System.Windows.Forms.Button GetButtonSaveExecute
        {
            get
            {
                return btn_SaveExecute;
            }
        }
    }
}
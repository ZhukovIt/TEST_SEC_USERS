
namespace SECURITY_USERS_GUI
{
    partial class Users
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
            this.ts_HeaderButtons = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SEC_USER_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs_SEC_USER = new System.Windows.Forms.BindingSource(this.components);
            this.sECUSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERTYPEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERKKMINNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERKKMLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERPROCURATORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERKKMPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERNOCHECKDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sECUSERBUILTINDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sECUSERPASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sECUSERLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECUSERFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_HeaderButtons
            // 
            this.ts_HeaderButtons.Location = new System.Drawing.Point(0, 0);
            this.ts_HeaderButtons.Name = "ts_HeaderButtons";
            this.ts_HeaderButtons.Size = new System.Drawing.Size(1055, 25);
            this.ts_HeaderButtons.TabIndex = 0;
            this.ts_HeaderButtons.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECUSERIDDataGridViewTextBoxColumn,
            this.sECUSERFIODataGridViewTextBoxColumn,
            this.sECUSERLOGINDataGridViewTextBoxColumn,
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn,
            this.SEC_USER_TYPE,
            this.sECUSERPASSWORDDataGridViewTextBoxColumn,
            this.sECUSERBUILTINDataGridViewCheckBoxColumn,
            this.sECUSERNOCHECKDataGridViewCheckBoxColumn,
            this.wORKIDDataGridViewTextBoxColumn,
            this.sECUSERKKMPASSWORDDataGridViewTextBoxColumn,
            this.sECUSERPROCURATORYDataGridViewTextBoxColumn,
            this.sECUSERKKMLOGINDataGridViewTextBoxColumn,
            this.sECUSERKKMINNDataGridViewTextBoxColumn,
            this.sECUSERTYPEIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs_SEC_USER;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1055, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // SEC_USER_TYPE
            // 
            this.SEC_USER_TYPE.DataPropertyName = "SEC_USER_TYPE_ID";
            this.SEC_USER_TYPE.DataSource = this.bs_SEC_USER;
            this.SEC_USER_TYPE.HeaderText = "Тип пользователя";
            this.SEC_USER_TYPE.Name = "SEC_USER_TYPE";
            this.SEC_USER_TYPE.ValueMember = "SEC_USER_TYPE_ID";
            // 
            // bs_SEC_USER
            // 
            this.bs_SEC_USER.DataMember = "SEC_USER";
            this.bs_SEC_USER.DataSource = typeof(SECURITY_USERS.dtsSEC_USERS);
            // 
            // sECUSERIDDataGridViewTextBoxColumn
            // 
            this.sECUSERIDDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_ID";
            this.sECUSERIDDataGridViewTextBoxColumn.HeaderText = "SEC_USER_ID";
            this.sECUSERIDDataGridViewTextBoxColumn.Name = "sECUSERIDDataGridViewTextBoxColumn";
            // 
            // sECUSERTYPEIDDataGridViewTextBoxColumn
            // 
            this.sECUSERTYPEIDDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_TYPE_ID";
            this.sECUSERTYPEIDDataGridViewTextBoxColumn.HeaderText = "SEC_USER_TYPE_ID";
            this.sECUSERTYPEIDDataGridViewTextBoxColumn.Name = "sECUSERTYPEIDDataGridViewTextBoxColumn";
            // 
            // sECUSERKKMINNDataGridViewTextBoxColumn
            // 
            this.sECUSERKKMINNDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_KKM_INN";
            this.sECUSERKKMINNDataGridViewTextBoxColumn.HeaderText = "SEC_USER_KKM_INN";
            this.sECUSERKKMINNDataGridViewTextBoxColumn.Name = "sECUSERKKMINNDataGridViewTextBoxColumn";
            // 
            // sECUSERKKMLOGINDataGridViewTextBoxColumn
            // 
            this.sECUSERKKMLOGINDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_KKM_LOGIN";
            this.sECUSERKKMLOGINDataGridViewTextBoxColumn.HeaderText = "SEC_USER_KKM_LOGIN";
            this.sECUSERKKMLOGINDataGridViewTextBoxColumn.Name = "sECUSERKKMLOGINDataGridViewTextBoxColumn";
            // 
            // sECUSERPROCURATORYDataGridViewTextBoxColumn
            // 
            this.sECUSERPROCURATORYDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_PROCURATORY";
            this.sECUSERPROCURATORYDataGridViewTextBoxColumn.HeaderText = "SEC_USER_PROCURATORY";
            this.sECUSERPROCURATORYDataGridViewTextBoxColumn.Name = "sECUSERPROCURATORYDataGridViewTextBoxColumn";
            // 
            // sECUSERKKMPASSWORDDataGridViewTextBoxColumn
            // 
            this.sECUSERKKMPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_KKM_PASSWORD";
            this.sECUSERKKMPASSWORDDataGridViewTextBoxColumn.HeaderText = "SEC_USER_KKM_PASSWORD";
            this.sECUSERKKMPASSWORDDataGridViewTextBoxColumn.Name = "sECUSERKKMPASSWORDDataGridViewTextBoxColumn";
            // 
            // wORKIDDataGridViewTextBoxColumn
            // 
            this.wORKIDDataGridViewTextBoxColumn.DataPropertyName = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn.HeaderText = "WORK_ID";
            this.wORKIDDataGridViewTextBoxColumn.Name = "wORKIDDataGridViewTextBoxColumn";
            // 
            // sECUSERNOCHECKDataGridViewCheckBoxColumn
            // 
            this.sECUSERNOCHECKDataGridViewCheckBoxColumn.DataPropertyName = "SEC_USER_NO_CHECK";
            this.sECUSERNOCHECKDataGridViewCheckBoxColumn.HeaderText = "SEC_USER_NO_CHECK";
            this.sECUSERNOCHECKDataGridViewCheckBoxColumn.Name = "sECUSERNOCHECKDataGridViewCheckBoxColumn";
            // 
            // sECUSERBUILTINDataGridViewCheckBoxColumn
            // 
            this.sECUSERBUILTINDataGridViewCheckBoxColumn.DataPropertyName = "SEC_USER_BUILTIN";
            this.sECUSERBUILTINDataGridViewCheckBoxColumn.HeaderText = "SEC_USER_BUILTIN";
            this.sECUSERBUILTINDataGridViewCheckBoxColumn.Name = "sECUSERBUILTINDataGridViewCheckBoxColumn";
            // 
            // sECUSERPASSWORDDataGridViewTextBoxColumn
            // 
            this.sECUSERPASSWORDDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_PASSWORD";
            this.sECUSERPASSWORDDataGridViewTextBoxColumn.HeaderText = "SEC_USER_PASSWORD";
            this.sECUSERPASSWORDDataGridViewTextBoxColumn.Name = "sECUSERPASSWORDDataGridViewTextBoxColumn";
            // 
            // sECUSERDISABLEDDataGridViewCheckBoxColumn
            // 
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.DataPropertyName = "SEC_USER_DISABLED";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.HeaderText = "SEC_USER_DISABLED";
            this.sECUSERDISABLEDDataGridViewCheckBoxColumn.Name = "sECUSERDISABLEDDataGridViewCheckBoxColumn";
            // 
            // sECUSERLOGINDataGridViewTextBoxColumn
            // 
            this.sECUSERLOGINDataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_LOGIN";
            this.sECUSERLOGINDataGridViewTextBoxColumn.HeaderText = "SEC_USER_LOGIN";
            this.sECUSERLOGINDataGridViewTextBoxColumn.Name = "sECUSERLOGINDataGridViewTextBoxColumn";
            // 
            // sECUSERFIODataGridViewTextBoxColumn
            // 
            this.sECUSERFIODataGridViewTextBoxColumn.DataPropertyName = "SEC_USER_FIO";
            this.sECUSERFIODataGridViewTextBoxColumn.HeaderText = "SEC_USER_FIO";
            this.sECUSERFIODataGridViewTextBoxColumn.Name = "sECUSERFIODataGridViewTextBoxColumn";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 434);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ts_HeaderButtons);
            this.Name = "Users";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_SEC_USER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_HeaderButtons;
        private System.Windows.Forms.BindingSource bs_SEC_USER;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn SEC_USER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sECUSERDISABLEDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sECUSERBUILTINDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sECUSERNOCHECKDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERKKMPASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERPROCURATORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERKKMLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERKKMINNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUSERTYPEIDDataGridViewTextBoxColumn;
    }
}


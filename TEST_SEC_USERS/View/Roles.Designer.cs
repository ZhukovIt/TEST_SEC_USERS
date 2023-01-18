
using System.Drawing;
using System.Windows.Forms;

namespace TEST_SEC_USERS.GUI
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts_btn_Role = new System.Windows.Forms.ToolStrip();
            this.btnAddNewRole = new System.Windows.Forms.ToolStripButton();
            this.btnCopyRole = new System.Windows.Forms.ToolStripButton();
            this.btnEditRole = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveRole = new System.Windows.Forms.ToolStripButton();
            this.ButtonsToFinderSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lblFinder = new System.Windows.Forms.ToolStripLabel();
            this.tbox_Roles = new System.Windows.Forms.ToolStripTextBox();
            this.btnClearFinderRoles = new System.Windows.Forms.ToolStripButton();
            this.dgv_SEC_ROLE = new System.Windows.Forms.DataGridView();
            this.sECROLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSEC_ROLE = new System.Windows.Forms.BindingSource(this.components);
            this.dtsSecUsers = new Model.dtsSecUsers();
            this.ts_btn_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_ROLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSEC_ROLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSecUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_btn_Role
            // 
            this.ts_btn_Role.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_btn_Role.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewRole,
            this.btnCopyRole,
            this.btnEditRole,
            this.btnRemoveRole,
            this.ButtonsToFinderSeparator,
            this.lblFinder,
            this.tbox_Roles,
            this.btnClearFinderRoles});
            this.ts_btn_Role.Location = new System.Drawing.Point(0, 0);
            this.ts_btn_Role.Name = "ts_btn_Role";
            this.ts_btn_Role.Size = new System.Drawing.Size(571, 39);
            this.ts_btn_Role.TabIndex = 0;
            this.ts_btn_Role.Text = "toolStrip1";
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewRole.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewRole.Image")));
            this.btnAddNewRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(36, 36);
            this.btnAddNewRole.Text = "Добавление новой роли";
            // 
            // btnCopyRole
            // 
            this.btnCopyRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyRole.Image = global::TEST_SEC_USERS.Properties.Resources.copyButton1;
            this.btnCopyRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyRole.Name = "btnCopyRole";
            this.btnCopyRole.Size = new System.Drawing.Size(36, 36);
            this.btnCopyRole.Text = "Создание роли на основе копии";
            // 
            // btnEditRole
            // 
            this.btnEditRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditRole.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRole.Image")));
            this.btnEditRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(36, 36);
            this.btnEditRole.Text = "Редактирование роли";
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveRole.Image")));
            this.btnRemoveRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(36, 36);
            this.btnRemoveRole.Text = "Удаление роли";
            // 
            // ButtonsToFinderSeparator
            // 
            this.ButtonsToFinderSeparator.Name = "ButtonsToFinderSeparator";
            this.ButtonsToFinderSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // lblFinder
            // 
            this.lblFinder.Name = "lblFinder";
            this.lblFinder.Size = new System.Drawing.Size(45, 36);
            this.lblFinder.Text = "Поиск:";
            // 
            // tbox_Roles
            // 
            this.tbox_Roles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Roles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbox_Roles.Name = "tbox_Roles";
            this.tbox_Roles.Size = new System.Drawing.Size(300, 39);
            // 
            // btnClearFinderRoles
            // 
            this.btnClearFinderRoles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearFinderRoles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearFinderRoles.Name = "btnClearFinderRoles";
            this.btnClearFinderRoles.Size = new System.Drawing.Size(23, 36);
            this.btnClearFinderRoles.Text = "X";
            // 
            // dgv_SEC_ROLE
            // 
            this.dgv_SEC_ROLE.AllowUserToAddRows = false;
            this.dgv_SEC_ROLE.AutoGenerateColumns = false;
            this.dgv_SEC_ROLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SEC_ROLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SEC_ROLE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sECROLENAMEDataGridViewTextBoxColumn});
            this.dgv_SEC_ROLE.DataSource = this.bsSEC_ROLE;
            this.dgv_SEC_ROLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SEC_ROLE.Location = new System.Drawing.Point(0, 39);
            this.dgv_SEC_ROLE.Name = "dgv_SEC_ROLE";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_SEC_ROLE.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SEC_ROLE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SEC_ROLE.Size = new System.Drawing.Size(571, 333);
            this.dgv_SEC_ROLE.TabIndex = 1;
            // 
            // sECROLENAMEDataGridViewTextBoxColumn
            // 
            this.sECROLENAMEDataGridViewTextBoxColumn.DataPropertyName = "SEC_ROLE_NAME";
            this.sECROLENAMEDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.sECROLENAMEDataGridViewTextBoxColumn.Name = "sECROLENAMEDataGridViewTextBoxColumn";
            this.sECROLENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSEC_ROLE
            // 
            this.bsSEC_ROLE.DataMember = "SEC_ROLE";
            this.bsSEC_ROLE.DataSource = this.dtsSecUsers;
            // 
            // dtsSecUsers
            // 
            this.dtsSecUsers.DataSetName = "dtsSecUsers";
            this.dtsSecUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(this.dgv_SEC_ROLE);
            this.Controls.Add(this.ts_btn_Role);
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Роли";
            this.ts_btn_Role.ResumeLayout(false);
            this.ts_btn_Role.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SEC_ROLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSEC_ROLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsSecUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_btn_Role;
        private System.Windows.Forms.ToolStripButton btnAddNewRole;
        private System.Windows.Forms.ToolStripButton btnRemoveRole;
        private System.Windows.Forms.ToolStripSeparator ButtonsToFinderSeparator;
        private System.Windows.Forms.BindingSource bsSEC_ROLE;
        private Model.dtsSecUsers dtsSecUsers;
        private System.Windows.Forms.DataGridView dgv_SEC_ROLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECROLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnCopyRole;
        private System.Windows.Forms.ToolStripButton btnEditRole;
        private System.Windows.Forms.ToolStripLabel lblFinder;
        private System.Windows.Forms.ToolStripTextBox tbox_Roles;
        private System.Windows.Forms.ToolStripButton btnClearFinderRoles;
        private TableLayoutPanel temp_TLP_SelectButtonContainer;
        private Button temp_btn_SelectRole;


        private void PrepareFormForGive_SEC_ROLE_ID()
        {
            temp_TLP_SelectButtonContainer = new TableLayoutPanel();
            temp_btn_SelectRole = new Button();

            temp_TLP_SelectButtonContainer.Controls.Add(temp_btn_SelectRole, 0, 0);
            Controls.Add(temp_TLP_SelectButtonContainer);

            dgv_SEC_ROLE.Dock = DockStyle.Top;
            dgv_SEC_ROLE.Size = new Size(571, 286);

            temp_TLP_SelectButtonContainer.ColumnCount = 1;
            temp_TLP_SelectButtonContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            temp_TLP_SelectButtonContainer.Controls.Add(temp_btn_SelectRole, 0, 0);
            temp_TLP_SelectButtonContainer.Dock = DockStyle.Bottom;
            temp_TLP_SelectButtonContainer.Location = new Point(0, 326);
            temp_TLP_SelectButtonContainer.Name = "TLP_SelectButtonContainer";
            temp_TLP_SelectButtonContainer.RowCount = 1;
            temp_TLP_SelectButtonContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            temp_TLP_SelectButtonContainer.Size = new Size(571, 46);
            temp_TLP_SelectButtonContainer.TabIndex = 2;

            temp_btn_SelectRole.Anchor = AnchorStyles.None;
            temp_btn_SelectRole.Location = new Point(225, 5);
            temp_btn_SelectRole.Name = "btn_SelectRole";
            temp_btn_SelectRole.Size = new Size(120, 35);
            temp_btn_SelectRole.TabIndex = 0;
            temp_btn_SelectRole.Text = "Выбрать";
            temp_btn_SelectRole.UseVisualStyleBackColor = true;
        }
    }
}
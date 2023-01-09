
namespace View
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
            this.ToolStripRoles = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewRole = new System.Windows.Forms.ToolStripButton();
            this.btnChangeRole = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveRole = new System.Windows.Forms.ToolStripButton();
            this.ButtonsToFinderSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStripRoles
            // 
            this.ToolStripRoles.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStripRoles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewRole,
            this.btnChangeRole,
            this.btnRemoveRole,
            this.ButtonsToFinderSeparator});
            this.ToolStripRoles.Location = new System.Drawing.Point(0, 0);
            this.ToolStripRoles.Name = "ToolStripRoles";
            this.ToolStripRoles.Size = new System.Drawing.Size(800, 39);
            this.ToolStripRoles.TabIndex = 0;
            this.ToolStripRoles.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNewRole
            // 
            this.btnAddNewRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNewRole.Image = global::View.Properties.Resources.Knob_Add;
            this.btnAddNewRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewRole.Name = "btnAddNewRole";
            this.btnAddNewRole.Size = new System.Drawing.Size(36, 36);
            this.btnAddNewRole.Text = "Добавление новой роли";
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChangeRole.Image = global::View.Properties.Resources.Knob_Refresh;
            this.btnChangeRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(36, 36);
            this.btnChangeRole.Text = "Изменение данных роли";
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemoveRole.Image = global::View.Properties.Resources.Knob_Remove_Red;
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
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ToolStripRoles);
            this.Name = "Roles";
            this.Text = "Roles";
            this.ToolStripRoles.ResumeLayout(false);
            this.ToolStripRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStripRoles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnAddNewRole;
        private System.Windows.Forms.ToolStripButton btnChangeRole;
        private System.Windows.Forms.ToolStripButton btnRemoveRole;
        private System.Windows.Forms.ToolStripSeparator ButtonsToFinderSeparator;
    }
}
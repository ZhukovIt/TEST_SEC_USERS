﻿
namespace TEST_SEC_USERS.View
{
    partial class Role
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
            this.btn_Accept = new System.Windows.Forms.Button();
            this.tBox_SEC_ROLE_NAME = new System.Windows.Forms.TextBox();
            this.lbl_SEC_ROLE_NAME = new System.Windows.Forms.Label();
            this.cb_SEC_ROLE_BUILTIN = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(185, 78);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Добавить";
            this.btn_Accept.UseVisualStyleBackColor = true;
            // 
            // tBox_SEC_ROLE_NAME
            // 
            this.tBox_SEC_ROLE_NAME.Location = new System.Drawing.Point(137, 31);
            this.tBox_SEC_ROLE_NAME.Name = "tBox_SEC_ROLE_NAME";
            this.tBox_SEC_ROLE_NAME.Size = new System.Drawing.Size(165, 20);
            this.tBox_SEC_ROLE_NAME.TabIndex = 1;
            // 
            // lbl_SEC_ROLE_NAME
            // 
            this.lbl_SEC_ROLE_NAME.AutoSize = true;
            this.lbl_SEC_ROLE_NAME.Location = new System.Drawing.Point(27, 34);
            this.lbl_SEC_ROLE_NAME.Name = "lbl_SEC_ROLE_NAME";
            this.lbl_SEC_ROLE_NAME.Size = new System.Drawing.Size(84, 13);
            this.lbl_SEC_ROLE_NAME.TabIndex = 2;
            this.lbl_SEC_ROLE_NAME.Text = "Название роли";
            // 
            // cb_SEC_ROLE_BUILTIN
            // 
            this.cb_SEC_ROLE_BUILTIN.AutoSize = true;
            this.cb_SEC_ROLE_BUILTIN.Location = new System.Drawing.Point(30, 82);
            this.cb_SEC_ROLE_BUILTIN.Name = "cb_SEC_ROLE_BUILTIN";
            this.cb_SEC_ROLE_BUILTIN.Size = new System.Drawing.Size(88, 17);
            this.cb_SEC_ROLE_BUILTIN.TabIndex = 3;
            this.cb_SEC_ROLE_BUILTIN.Text = "Встроенный";
            this.cb_SEC_ROLE_BUILTIN.UseVisualStyleBackColor = true;
            // 
            // Role
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 135);
            this.Controls.Add(this.cb_SEC_ROLE_BUILTIN);
            this.Controls.Add(this.lbl_SEC_ROLE_NAME);
            this.Controls.Add(this.tBox_SEC_ROLE_NAME);
            this.Controls.Add(this.btn_Accept);
            this.Name = "Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.TextBox tBox_SEC_ROLE_NAME;
        private System.Windows.Forms.Label lbl_SEC_ROLE_NAME;
        private System.Windows.Forms.CheckBox cb_SEC_ROLE_BUILTIN;
    }
}
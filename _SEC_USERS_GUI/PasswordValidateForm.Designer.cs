
namespace _SEC_USERS_GUI
{
    partial class PasswordValidateForm
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
            this.TLP_MainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btn_TryChangePasswordAndAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TLP_MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_MainContainer
            // 
            this.TLP_MainContainer.ColumnCount = 2;
            this.TLP_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MainContainer.Controls.Add(this.btn_TryChangePasswordAndAccept, 0, 3);
            this.TLP_MainContainer.Controls.Add(this.label1, 0, 0);
            this.TLP_MainContainer.Controls.Add(this.label2, 0, 1);
            this.TLP_MainContainer.Controls.Add(this.label3, 0, 2);
            this.TLP_MainContainer.Controls.Add(this.textBox1, 1, 0);
            this.TLP_MainContainer.Controls.Add(this.textBox2, 1, 1);
            this.TLP_MainContainer.Controls.Add(this.textBox3, 1, 2);
            this.TLP_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_MainContainer.Location = new System.Drawing.Point(0, 0);
            this.TLP_MainContainer.Name = "TLP_MainContainer";
            this.TLP_MainContainer.RowCount = 4;
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_MainContainer.Size = new System.Drawing.Size(393, 190);
            this.TLP_MainContainer.TabIndex = 0;
            // 
            // btn_TryChangePasswordAndAccept
            // 
            this.btn_TryChangePasswordAndAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TLP_MainContainer.SetColumnSpan(this.btn_TryChangePasswordAndAccept, 2);
            this.btn_TryChangePasswordAndAccept.Location = new System.Drawing.Point(96, 150);
            this.btn_TryChangePasswordAndAccept.Name = "btn_TryChangePasswordAndAccept";
            this.btn_TryChangePasswordAndAccept.Size = new System.Drawing.Size(200, 30);
            this.btn_TryChangePasswordAndAccept.TabIndex = 0;
            this.btn_TryChangePasswordAndAccept.Text = "Подтвердить";
            this.btn_TryChangePasswordAndAccept.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Новый пароль ещё раз";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(214, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(214, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(214, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 2;
            // 
            // PasswordValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 190);
            this.Controls.Add(this.TLP_MainContainer);
            this.Name = "PasswordValidateForm";
            this.Text = "Изменение пароля пользователя";
            this.TLP_MainContainer.ResumeLayout(false);
            this.TLP_MainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_MainContainer;
        private System.Windows.Forms.Button btn_TryChangePasswordAndAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
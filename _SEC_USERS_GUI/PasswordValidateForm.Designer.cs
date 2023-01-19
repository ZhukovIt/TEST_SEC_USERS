
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
            this.SuspendLayout();
            // 
            // TLP_MainContainer
            // 
            this.TLP_MainContainer.ColumnCount = 2;
            this.TLP_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_MainContainer.Location = new System.Drawing.Point(0, 0);
            this.TLP_MainContainer.Name = "TLP_MainContainer";
            this.TLP_MainContainer.RowCount = 4;
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_MainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_MainContainer.Size = new System.Drawing.Size(471, 230);
            this.TLP_MainContainer.TabIndex = 0;
            // 
            // PasswordValidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 230);
            this.Controls.Add(this.TLP_MainContainer);
            this.Name = "PasswordValidateForm";
            this.Text = "Изменение пароля пользователя";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_MainContainer;
    }
}

namespace _SEC_USERS_GUI
{
    partial class DeleteAnswerForm
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
            this.TLP_ElementsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btn_YesAnswer = new System.Windows.Forms.Button();
            this.btn_NoAnswer = new System.Windows.Forms.Button();
            this.textBox_Information = new System.Windows.Forms.TextBox();
            this.TLP_ElementsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_ElementsContainer
            // 
            this.TLP_ElementsContainer.ColumnCount = 2;
            this.TLP_ElementsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_ElementsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_ElementsContainer.Controls.Add(this.btn_YesAnswer, 0, 1);
            this.TLP_ElementsContainer.Controls.Add(this.btn_NoAnswer, 1, 1);
            this.TLP_ElementsContainer.Controls.Add(this.textBox_Information, 0, 0);
            this.TLP_ElementsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_ElementsContainer.Location = new System.Drawing.Point(0, 0);
            this.TLP_ElementsContainer.Name = "TLP_ElementsContainer";
            this.TLP_ElementsContainer.RowCount = 2;
            this.TLP_ElementsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_ElementsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TLP_ElementsContainer.Size = new System.Drawing.Size(399, 144);
            this.TLP_ElementsContainer.TabIndex = 0;
            // 
            // btn_YesAnswer
            // 
            this.btn_YesAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_YesAnswer.Location = new System.Drawing.Point(39, 89);
            this.btn_YesAnswer.Name = "btn_YesAnswer";
            this.btn_YesAnswer.Size = new System.Drawing.Size(120, 30);
            this.btn_YesAnswer.TabIndex = 0;
            this.btn_YesAnswer.Text = "Да";
            this.btn_YesAnswer.UseVisualStyleBackColor = true;
            this.btn_YesAnswer.Click += new System.EventHandler(this.btn_YesAnswer_Click);
            // 
            // btn_NoAnswer
            // 
            this.btn_NoAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NoAnswer.Location = new System.Drawing.Point(239, 89);
            this.btn_NoAnswer.Name = "btn_NoAnswer";
            this.btn_NoAnswer.Size = new System.Drawing.Size(120, 30);
            this.btn_NoAnswer.TabIndex = 0;
            this.btn_NoAnswer.Text = "Нет";
            this.btn_NoAnswer.UseVisualStyleBackColor = true;
            this.btn_NoAnswer.Click += new System.EventHandler(this.btn_NoAnswer_Click);
            // 
            // textBox_Information
            // 
            this.textBox_Information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Information.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TLP_ElementsContainer.SetColumnSpan(this.textBox_Information, 2);
            this.textBox_Information.Location = new System.Drawing.Point(49, 25);
            this.textBox_Information.Name = "textBox_Information";
            this.textBox_Information.ReadOnly = true;
            this.textBox_Information.Size = new System.Drawing.Size(300, 13);
            this.textBox_Information.TabIndex = 1;
            this.textBox_Information.Text = "Вы точно хотите удалить Х выбранных строк?";
            this.textBox_Information.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 144);
            this.Controls.Add(this.TLP_ElementsContainer);
            this.Name = "DeleteAnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление выбранных пользователей";
            this.TLP_ElementsContainer.ResumeLayout(false);
            this.TLP_ElementsContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_ElementsContainer;
        private System.Windows.Forms.Button btn_YesAnswer;
        private System.Windows.Forms.Button btn_NoAnswer;
        private System.Windows.Forms.TextBox textBox_Information;
    }
}
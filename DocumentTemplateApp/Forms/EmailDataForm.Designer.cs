
namespace DocumentTemplateApp
{
    partial class EmailDataForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromEmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordEmailTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToEmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Ваш адрес электронной почты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль";
            // 
            // FromEmailTextBox
            // 
            this.FromEmailTextBox.Location = new System.Drawing.Point(24, 53);
            this.FromEmailTextBox.Name = "FromEmailTextBox";
            this.FromEmailTextBox.Size = new System.Drawing.Size(237, 20);
            this.FromEmailTextBox.TabIndex = 2;
            // 
            // PasswordEmailTextBox
            // 
            this.PasswordEmailTextBox.Location = new System.Drawing.Point(24, 104);
            this.PasswordEmailTextBox.Name = "PasswordEmailTextBox";
            this.PasswordEmailTextBox.Size = new System.Drawing.Size(237, 20);
            this.PasswordEmailTextBox.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(24, 210);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(186, 210);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите адрес электронной почты получателя";
            // 
            // ToEmailTextBox
            // 
            this.ToEmailTextBox.Location = new System.Drawing.Point(24, 163);
            this.ToEmailTextBox.Name = "ToEmailTextBox";
            this.ToEmailTextBox.Size = new System.Drawing.Size(237, 20);
            this.ToEmailTextBox.TabIndex = 7;
            // 
            // EmailDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.ToEmailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PasswordEmailTextBox);
            this.Controls.Add(this.FromEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 320);
            this.MinimumSize = new System.Drawing.Size(300, 320);
            this.Name = "EmailDataForm";
            this.Text = "Ввод данных";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FromEmailTextBox;
        private System.Windows.Forms.TextBox PasswordEmailTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToEmailTextBox;
    }
}
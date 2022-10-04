
namespace DocumentTemplateApp
{
    partial class MainForm
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
            this.DirectoryButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FileTemplateLabel = new System.Windows.Forms.Label();
            this.RichTB = new System.Windows.Forms.RichTextBox();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.FormTemplateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ViewTemplateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirectoryButton
            // 
            this.DirectoryButton.Location = new System.Drawing.Point(12, 12);
            this.DirectoryButton.Name = "DirectoryButton";
            this.DirectoryButton.Size = new System.Drawing.Size(90, 35);
            this.DirectoryButton.TabIndex = 0;
            this.DirectoryButton.Text = "Выбор шаблона";
            this.DirectoryButton.UseVisualStyleBackColor = true;
            this.DirectoryButton.Click += new System.EventHandler(this.DirectoryButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "docx";
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = ".docx|*.docx";
            // 
            // FileTemplateLabel
            // 
            this.FileTemplateLabel.AutoSize = true;
            this.FileTemplateLabel.Location = new System.Drawing.Point(12, 471);
            this.FileTemplateLabel.Name = "FileTemplateLabel";
            this.FileTemplateLabel.Size = new System.Drawing.Size(102, 13);
            this.FileTemplateLabel.TabIndex = 1;
            this.FileTemplateLabel.Text = "Шаблон не выбран";
            // 
            // RichTB
            // 
            this.RichTB.Location = new System.Drawing.Point(12, 58);
            this.RichTB.Name = "RichTB";
            this.RichTB.ReadOnly = true;
            this.RichTB.Size = new System.Drawing.Size(318, 397);
            this.RichTB.TabIndex = 2;
            this.RichTB.Text = "";
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablePanel.Location = new System.Drawing.Point(359, 58);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(300, 397);
            this.TablePanel.TabIndex = 3;
            // 
            // FormTemplateButton
            // 
            this.FormTemplateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormTemplateButton.Enabled = false;
            this.FormTemplateButton.Location = new System.Drawing.Point(359, 461);
            this.FormTemplateButton.Name = "FormTemplateButton";
            this.FormTemplateButton.Size = new System.Drawing.Size(92, 23);
            this.FormTemplateButton.TabIndex = 4;
            this.FormTemplateButton.Text = "Сформировать";
            this.FormTemplateButton.UseVisualStyleBackColor = true;
            this.FormTemplateButton.Click += new System.EventHandler(this.FormTemplateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(457, 461);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EmailButton
            // 
            this.EmailButton.Enabled = false;
            this.EmailButton.Location = new System.Drawing.Point(538, 461);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(121, 23);
            this.EmailButton.TabIndex = 6;
            this.EmailButton.Text = "Отправить по email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(255, 12);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(75, 35);
            this.HistoryButton.TabIndex = 7;
            this.HistoryButton.Text = "История";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // ViewTemplateButton
            // 
            this.ViewTemplateButton.Enabled = false;
            this.ViewTemplateButton.Location = new System.Drawing.Point(108, 12);
            this.ViewTemplateButton.Name = "ViewTemplateButton";
            this.ViewTemplateButton.Size = new System.Drawing.Size(141, 35);
            this.ViewTemplateButton.TabIndex = 8;
            this.ViewTemplateButton.Text = "Отобразить шаблон";
            this.ViewTemplateButton.UseVisualStyleBackColor = true;
            this.ViewTemplateButton.Click += new System.EventHandler(this.ViewTemplateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.ViewTemplateButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FormTemplateButton);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.RichTB);
            this.Controls.Add(this.FileTemplateLabel);
            this.Controls.Add(this.DirectoryButton);
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "MainForm";
            this.Text = "Шаблонизатор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirectoryButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label FileTemplateLabel;
        private System.Windows.Forms.RichTextBox RichTB;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Button FormTemplateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button ViewTemplateButton;
    }
}


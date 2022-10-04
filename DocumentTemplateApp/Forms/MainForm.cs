using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Главная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Начало шаблона.
        /// </summary>
        private const string FirstBorder = "{";

        /// <summary>
        /// Конец шаблона.
        /// </summary>
        private const string LastBorder = "}";

        /// <summary>
        /// Путь файла шаблона.
        /// </summary>
        private string fileNameTempate;

        /// <summary>
        /// Список полей шаблона.
        /// </summary>
        private List<string> fieldTemplate;

        /// <summary>
        /// Шаблон.
        /// </summary>
        private Template templateOrigin;

        /// <summary>
        /// Редактируемый шаблон.
        /// </summary>
        private Template templateEdit;

        /// <summary>
        /// Массив текстовых полей.
        /// </summary>
        private TextBox[] textBoxArray;

        /// <summary>
        /// Массив подписей полей.
        /// </summary>
        private Label[] labelArray;

        /// <summary>
        /// Электронная почта отправителя.
        /// </summary>
        public string From;

        /// <summary>
        /// Электронная почта получателя.
        /// </summary>
        public string To;
        
        /// <summary>
        /// Пароль от электронной почты.
        /// </summary>
        public string PasswordEmail;

        /// <summary>
        /// Конструктор.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();   
        }

        /// <summary>
        /// Нажатие кнопки "Выбор шаблона".
        /// </summary>
        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            Logger.Record("Выбор шаблона");

            TablePanel.Controls.Clear();

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            fileNameTempate = openFileDialog.FileName;
            FileTemplateLabel.Text = fileNameTempate;
            
            SelectTemplate();

            RichTB.Text = templateOrigin.GetText();
            FormTemplateButton.Enabled = true;
            ViewTemplateButton.Enabled = false;
        }

        /// <summary>
        /// Выбирает шаблон.
        /// </summary>
        private void SelectTemplate()
        {
            templateOrigin = new TemplateDocx(fileNameTempate, FirstBorder, LastBorder);
            fieldTemplate = templateOrigin.GetFieldsTemplate();

            templateEdit = templateOrigin;

            textBoxArray = new TextBox[fieldTemplate.Count];
            labelArray = new Label[fieldTemplate.Count];

            for (int i = 0; i < fieldTemplate.Count; i++)
            {
                textBoxArray[i] = new TextBox();
                textBoxArray[i].Location = new System.Drawing.Point(130, 10 + i * 30);
                textBoxArray[i].Size = new System.Drawing.Size(120, 23);
                
                labelArray[i] = new Label();
                labelArray[i].AutoSize = true;
                labelArray[i].Location = new System.Drawing.Point(10, 10 + i * 30);
                labelArray[i].Size = new System.Drawing.Size(120, 23);
                labelArray[i].Text = fieldTemplate[i];
            }

            TablePanel.Controls.AddRange(textBoxArray);
            TablePanel.Controls.AddRange(labelArray);
        }

        /// <summary>
        /// Нажатие на кнопку "Сформировать".
        /// </summary>
        private void FormTemplateButton_Click(object sender, EventArgs e)
        {
            Logger.Record("Формирование документа");

            var dictionary = new Dictionary<string, string>();

            for (int i = 0; i < fieldTemplate.Count; i++)
            {
                dictionary.Add(labelArray[i].Text, textBoxArray[i].Text);
            }

            templateOrigin.ReplaceText(dictionary);
            templateEdit = templateOrigin;
            templateOrigin = new TemplateDocx(fileNameTempate, FirstBorder, LastBorder);
            RichTB.Text = templateEdit.GetText();

            ViewTemplateButton.Enabled = true;
            SaveButton.Enabled = true;
            EmailButton.Enabled = true;
        }

        /// <summary>
        /// Нажатие на кнопку "Сохранить".
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Logger.Record("Сохранение документа");

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            templateEdit.SaveFile(saveFileDialog1.FileName);
        }

        /// <summary>
        /// Нажатие на кнопку "Отправить на email".
        /// </summary>
        private void EmailButton_Click(object sender, EventArgs e)
        {
            Logger.Record("Отправка по email");
            
            const string emailFileName = "lastfile.docx";
            var form = new EmailDataForm();
            form.Owner = this;

            templateEdit.SaveFile(emailFileName);

            if (form.ShowDialog() != DialogResult.Cancel)
            {
                if(EmailHelper.Send(From, To, PasswordEmail, emailFileName))
                {
                    MessageBox.Show("Сообщение удачно отправлено");
                }
                else
                {
                    MessageBox.Show("Сообщение не удалось отправить");
                }
            }    
        }

        /// <summary>
        /// Нажатие на кнопку "История".
        /// </summary>
        private void HistoryButton_Click(object sender, EventArgs e)
        {
            var form = new HistoryForm();
            form.Show();
        }

        /// <summary>
        /// Нажатие на кнопку "Показать шаблон".
        /// </summary>
        private void ViewTemplateButton_Click(object sender, EventArgs e)
        {
            RichTB.Text = templateOrigin.GetText();
            ViewTemplateButton.Enabled = false;
        }
    }
}

using System;
using System.Windows.Forms;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Форма отправки электронного письма.
    /// </summary>
    public partial class EmailDataForm : Form
    {
        public EmailDataForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var main = Owner as MainForm;
            if (main != null)
            {
                main.From = FromEmailTextBox.Text;
                main.PasswordEmail = PasswordEmailTextBox.Text;
                main.To = ToEmailTextBox.Text;
            }       
        }
    }
}

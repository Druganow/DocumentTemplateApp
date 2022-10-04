using System;
using System.Linq;
using System.Windows.Forms;

namespace DocumentTemplateApp
{
    /// <summary>
    /// Форма истории действий.
    /// </summary>
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            using (var db = new ApplicationContext())
            { 
                var i = 1;
                foreach (var operation in db.Operations.OrderByDescending(x=>x.Id).Take<Operation>(50))
                {
                    HistoryTable.RowStyles.Add(new RowStyle());

                    var idLabelId = new Label();
                    idLabelId.Text = operation.Id.ToString();
                    HistoryTable.Controls.Add(idLabelId, 0, i);

                    var operationLabel = new Label();
                    operationLabel.Text = operation.OperationName.ToString();
                    HistoryTable.Controls.Add(operationLabel, 1, i);

                    var dateLabel = new Label();
                    dateLabel.Text = operation.OperationDate.ToString();
                    HistoryTable.Controls.Add(dateLabel, 2, i);
                    i++;
                }
            }
        }
    }
}

using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;

namespace ClientManagerForms
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();

            LoadData();
        }

        private async void LoadData()
        {
            // TODO - filter
            List<Transaction> transactions = await DataAccess.GetFilteredTransactions(null, null);

            GenerateRows(transactions);
        }

        private async void conductButton_Click(object sender, EventArgs e)
        {
            var transactionRow = transactionsDataGridView.SelectedCells[0].OwningRow;

            DateTime? success = await DataAccess.ConductTransaction((int)transactionRow.Tag);

            transactionRow.Cells[6].Value = success;

            MessageBox.Show($"Transaction {(success is null ? "failed" : "succeeded")}");
        }

        private async void accountFilterButton_Click(object sender, EventArgs e)
        {
            string? accountFrom = fromAccountFilterTextBox.Text.Length == 10 ? fromAccountFilterTextBox.Text : null;
            string? accountTo = toAccountFilterTextBox.Text.Length == 10 ? toAccountFilterTextBox.Text : null;

            if (accountFrom == null && accountTo == null)
            {
                return;
            }

            transactionsDataGridView.Rows.Clear();

            List<Transaction> transactions = await DataAccess.GetFilteredTransactions(accountFrom, accountTo);

            GenerateRows(transactions);
        }

        private void GenerateRows(List<Transaction> transactions)
        {
            foreach (var tran in transactions)
            {
                var row = new DataGridViewRow();
                row.Height = 50;
                row.CreateCells(transactionsDataGridView);

                row.Tag = tran.Id;

                row.Cells[0].Value = tran.ClientFrom.FullName;
                row.Cells[1].Value = tran.ClientTo.FullName;
                row.Cells[2].Value = tran.AccountFrom;
                row.Cells[3].Value = tran.AccountTo;
                row.Cells[4].Value = tran.Amount;
                row.Cells[5].Value = tran.DateTimeCreated;
                row.Cells[6].Value = tran.DateTimeTranfered;

                transactionsDataGridView.Rows.Add(row);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

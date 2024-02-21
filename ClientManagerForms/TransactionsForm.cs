using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void conductButton_Click(object sender, EventArgs e)
        {
            var transactionRow = transactionsDataGridView.SelectedCells[0].OwningRow;

            int success = await DataAccess.ConductTransaction((int)transactionRow.Tag);

            MessageBox.Show($"Transaction { (success > 0 ? "succeeded" : "failed") }");
        }
    }
}

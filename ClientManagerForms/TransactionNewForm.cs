using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;
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
    public partial class TransactionNewForm : Form
    {
        Client _clientFrom;
        Client _clientTo;
        public TransactionNewForm()
        {
            InitializeComponent();
        }

        private async void accountFromButton_Click(object sender, EventArgs e)
        {
            _clientFrom = await DataAccess.GetClientByAccount(accountFromTextBox.Text);
            if (_clientFrom != null)
            {
                clientFromTextBox.Text = $"{_clientFrom.SurName} {_clientFrom.Name}";
            }
            else
            {
                clientFromTextBox.Text = "Not found";
            }
        }

        private async void accountToButton_Click(object sender, EventArgs e)
        {
            _clientTo = await DataAccess.GetClientByAccount(accountToTextBox.Text);
            if (_clientTo != null)
            {
                clientToTextBox.Text = $"{_clientTo.SurName} {_clientTo.Name}";
            }
            else
            {
                clientToTextBox.Text = "Not found";
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_clientFrom == null || _clientTo == null)
            {
                return;
            }
            decimal.TryParse(amountTextBox.Text, out decimal amount);
            DataAccess.CreateTransaction(_clientFrom.Id, _clientTo.Id, accountFromTextBox.Text, accountToTextBox.Text, amount, isImidiateCheckBox.Checked);

            Close();
        }
    }
}

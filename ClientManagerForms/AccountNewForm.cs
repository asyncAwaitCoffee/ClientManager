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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientManagerForms
{
    public partial class AccountNewForm : Form
    {
        private BindingList<Account> _accounts;
        private DataGridViewRow _clientRow;
        public AccountNewForm(DataGridViewRow clientRow, BindingList<Account> accounts)
        {
            InitializeComponent();

            _accounts = accounts;
            _clientRow = clientRow;

            clientFullNameTextBox.Text = $"{clientRow.Cells[2].Value} {clientRow.Cells[1].Value}";
        }

        private async void createAccountButton_Click(object sender, EventArgs e)
        {
            if (accountCodeErrorProvider.HasErrors)
            {
                return;
            }

            int result = await DataAccess.CreateAccount((int)_clientRow.Cells[0].Value, newAccountCodeTextBox.Text);

            if (result < 1)
            {
                return;
            }

            _accounts.Add(new Account() { Code = newAccountCodeTextBox.Text });

            MessageBox.Show("Account successfuly created.");

            Close();
        }

        private void newAccountCodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (newAccountCodeTextBox.Text.Length < 10)
            {
                accountCodeErrorProvider.SetError(newAccountCodeTextBox, "Account code should be 10 symbols.");
            }
            else if (!int.TryParse(newAccountCodeTextBox.Text[0].ToString(), out _))
            {
                accountCodeErrorProvider.SetError(newAccountCodeTextBox, "Account code should start with integer.");
            }
            else
            {
                accountCodeErrorProvider.Clear();
            }
        }

        private void AccountNewForm_Shown(object sender, EventArgs e)
        {
            newAccountCodeTextBox.Focus();
        }
    }
}

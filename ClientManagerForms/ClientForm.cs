using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;
using Microsoft.Identity.Client;
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
    public partial class ClientForm : Form
    {
        private DataGridViewRow ClientRow { get; set; }
        private BindingList<Account> Accounts { get; set; } = new BindingList<Account>();

        public ClientForm(DataGridViewRow clientRow)
        {
            ClientRow = clientRow;

            InitializeComponent();

            LoadData();
        }

        private async void LoadData()
        {
            clientSurnameTextBox.Text = ClientRow.Cells[1].Value.ToString();
            clientFullNameTextBox.Text = ClientRow.Cells[2].Value.ToString();

            clientAccountsIdscomboBox.DataSource = Accounts;
            clientAccountsIdscomboBox.DisplayMember = "Code";

            var result = await DataAccess.GetClientAccounts((int)ClientRow.Cells[0].Value);

            foreach (var item in result)
            {
                Accounts.Add(item);
            }

            Account? account = clientAccountsIdscomboBox.SelectedItem as Account;

            balanceTextBox.Text = $"{ account?.Balance }";
        }

        private async void saveClientButton_Click(object sender, EventArgs e)
        {
            await DataAccess.UpdateClient((int)ClientRow.Cells[0].Value, clientSurnameTextBox.Text, clientFullNameTextBox.Text);

            ClientRow.Cells[1].Value = clientSurnameTextBox.Text;
            ClientRow.Cells[2].Value = clientFullNameTextBox.Text;

            MessageBox.Show("Data successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientAccountsIdscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            Account account = comboBox.SelectedItem as Account;

            balanceTextBox.Text = $"{ account.Balance }";
        }
    }
}

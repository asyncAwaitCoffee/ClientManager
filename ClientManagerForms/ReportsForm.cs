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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private async void okButton_Click(object sender, EventArgs e)
        {
            // TODO - global const
            if (clientByAccountTextBox.Text.Length < 10)
            {
                return;
            }

            Client client = await DataAccess.GetClientByAccount(clientByAccountTextBox.Text);

            if (client != null)
            {
                var result = await DataAccess.GetClientAccounts(client.Id);

                foreach (var account in result)
                {
                    accountsCheckedListBox.Items.Add(account.Code);
                }
            }
            else
            {
                MessageBox.Show($"Client with code [ {clientByAccountTextBox.Text} ] does not exist.");
            }
        }

        private async void buildReportButton_Click(object sender, EventArgs e)
        {
            // TODO - more complex report ??
            if (accountsCheckedListBox.CheckedItems.Count < 1)
            {
                MessageBox.Show("No accounts selected.");
                return;
            }

            string accounts = "";
            foreach (var item in accountsCheckedListBox.CheckedItems)
            {
                accounts += item.ToString() + ',';
            }

            accounts.TrimEnd(',');

            Report report = await DataAccess.GetAccountsReport(accounts);

#if DEBUG
            string path = @$"D:\Programming\projects\ClientManager\Reports\report_{clientByAccountTextBox.Text}.txt";
#else
            string path = @"Reports\test.txt";
#endif
            // TODO - file checks and manipulations
            await File.WriteAllTextAsync(path, report.ToString());

            MessageBox.Show("Report saved.");

        }
    }
}

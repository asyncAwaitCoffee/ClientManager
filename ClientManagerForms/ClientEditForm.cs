using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;
using System.ComponentModel;

namespace ClientManagerForms
{
    public partial class ClientEditForm : Form
    {
        private DataGridViewRow ClientRow { get; set; }
        private BindingList<Account> Accounts { get; set; } = new BindingList<Account>();

        public ClientEditForm(DataGridViewRow clientRow)
        {
            ClientRow = clientRow;

            InitializeComponent();

            LoadData();

            clientSurnameTextBox.TextChanged += clientSurnameTextBox_TextChanged;
            clientNameTextBox.TextChanged += clientNameTextBox_TextChanged;
        }

        private async void LoadData()
        {
            clientSurnameTextBox.Text = ClientRow.Cells[1].Value.ToString();
            clientNameTextBox.Text = ClientRow.Cells[2].Value.ToString();

            clientAccountsIdscomboBox.DataSource = Accounts;
            clientAccountsIdscomboBox.DisplayMember = "Code";

            var result = await DataAccess.GetClientAccounts((int)ClientRow.Cells[0].Value);

            foreach (var item in result)
            {
                Accounts.Add(item);
            }

            Account? account = clientAccountsIdscomboBox.SelectedItem as Account;

            balanceTextBox.Text = $"{account?.Balance}";
        }

        private async void saveClientButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm the change", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result != DialogResult.OK)
            {
                return;
            }

            await DataAccess.UpdateClient((int)ClientRow.Cells[0].Value, clientSurnameTextBox.Text, clientNameTextBox.Text);

            ClientRow.Cells[1].Value = clientSurnameTextBox.Text;
            ClientRow.Cells[2].Value = clientNameTextBox.Text;

            MessageBox.Show("Data successfuly saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientAccountsIdscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            Account account = comboBox.SelectedItem as Account;

            balanceTextBox.Text = $"{account.Balance}";
        }

        private void clientSurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveClientButton.Enabled = true;
        }

        private void clientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveClientButton.Enabled = true;
        }

        private void addNewAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountNewForm form = new AccountNewForm(ClientRow, Accounts);
            form.ShowDialog();
        }
    }
}

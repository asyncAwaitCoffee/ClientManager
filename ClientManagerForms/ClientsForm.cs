using ClientManagerLibrary;
using ClientManagerLibrary.DataAccess;
using ClientManagerLibrary.Models;
using System.ComponentModel;

namespace ClientManagerForms
{
    public partial class ClientsForm : Form
    {
        private BindingList<Client> _clients;
        private int _currentPageNo = 1;
        private int _itemsPerPage = 20;
        public ClientsForm()
        {
            InitializeComponent();

            if (Manager.Instance().PermissionsLevel > 1)
            {
                permissionsToolStripMenuItem.Visible = true;
            }

            LoadClients();
        }

        private async void LoadClients()
        {
            _clients = await DataAccess.GetUserClients(Manager.Instance().UserId, _currentPageNo, _itemsPerPage);

            clientsDataGridView.DataSource = _clients;

            clientsDataGridView.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.Columns["isVIP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.Columns["GenderChar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void clientsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form clientForm = new ClientEditForm(clientsDataGridView.SelectedCells[0].OwningRow);
            clientForm.ShowDialog();
        }

        private void ClientsForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                clientsFormNotifyIcon.Icon = SystemIcons.Information;
                clientsFormNotifyIcon.ShowBalloonTip(1);
            }
        }

        private void clientsFormNotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //MessageBox.Show("Balloon");
            clientsFormNotifyIcon.Icon = null;
        }

        private void clientsFormNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //MessageBox.Show("NotifyIcon");
            clientsFormNotifyIcon.Icon = null;
        }

        private void createMenuSubItemClient_Click(object sender, EventArgs e)
        {
            Form clientNewForm = new ClientNewForm(_clients);
            clientNewForm.ShowDialog();
        }

        private async void nextPageNoButton_Click(object sender, EventArgs e)
        {
            _currentPageNo++;

            previousPageNoButton.Enabled = true;

            var nextClients = await DataAccess.GetUserClients(Manager.Instance().UserId, _currentPageNo, _itemsPerPage);

            if (nextClients.Count() < _itemsPerPage)
            {
                nextPageNoButton.Enabled = false;
            }
            // TODO - cache previous results + refresh
            _clients.Clear();

            foreach (var client in nextClients)
            {
                _clients.Add(client);
            }

        }

        private async void previousPageNoButton_Click(object sender, EventArgs e)
        {
            _currentPageNo--;
            var nextClients = await DataAccess.GetUserClients(Manager.Instance().UserId, _currentPageNo, _itemsPerPage);

            nextPageNoButton.Enabled = true;

            if (_currentPageNo < 2)
            {
                previousPageNoButton.Enabled = false;
            }
            // TODO - cache previous results + refresh
            _clients.Clear();

            foreach (var client in nextClients)
            {
                _clients.Add(client);
            }
        }

        private void managersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.ShowDialog();
        }

        private void transactionsMenuItemNew_Click(object sender, EventArgs e)
        {
            TransactionNewForm form = new TransactionNewForm();
            form.ShowDialog();
        }

        private void transactionsMenuItemStatus_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            form.ShowDialog();
        }

        private void managersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SuperManagerForm form = new SuperManagerForm();
            form.ShowDialog();
        }
    }
}

using ClientManagerLibrary;
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
                createMenuSubItemManager.Visible = true;
                permissionsToolStripMenuItem.Visible = true;
            }

            LoadClients();
        }

        private async void LoadClients()
        {
            // TODO - page number
            _clients = await DataAccess.GetUserClients(Manager.Instance().UserId, _currentPageNo, _itemsPerPage);
            //int counter = 0;
            //foreach (Client client in clients)
            //{
            //    counter++;

            //    var row = new DataGridViewRow();
            //    row.Height = 50;
            //    row.CreateCells(clientsDataGridView);

            //    row.Cells[0].Value = client.Id;
            //    row.Cells[1].Value = client.SurName;
            //    row.Cells[2].Value = client.FullName;

            //    row.Cells[4].Value = true;

            //    if (counter % 2 == 0)
            //    {
            //        row.DefaultCellStyle.BackColor = Color.LightGray;
            //    }

            //    clientsDataGridView.Rows.Add(row);

            //}

            clientsDataGridView.DataSource = _clients;

            clientsDataGridView.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.Columns["isVIP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientsDataGridView.Columns["GenderChar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void clientsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = clientsDataGridView.SelectedCells[0].OwningRow;
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
    }
}

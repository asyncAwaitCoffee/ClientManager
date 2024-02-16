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
        public ClientsForm()
        {
            InitializeComponent();

            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;


            LoadClients();
        }

        private async void LoadClients()
        {
            int counter = 0;

            List<Client> clients = await DataAccess.GetUserClients();
            foreach (Client client in clients)
            {
                counter++;

                var row = new DataGridViewRow();
                row.Height = 50;
                row.CreateCells(clientsDataGridView);

                row.Cells[0].Value = client.Id;
                row.Cells[1].Value = client.SurName;
                row.Cells[2].Value = client.FullName;

                // TODO - vip check
                row.Cells[4].Value = true;

                if (counter % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }

                clientsDataGridView.Rows.Add(row);

            }

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
                clientsFormNotifyIcon.ShowBalloonTip(5);
            }
        }

        private void clientsFormNotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void clientsFormNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void createMenuSubItemClient_Click(object sender, EventArgs e)
        {
            Form clientNewForm = new ClientNewForm();
            clientNewForm.ShowDialog();
        }
    }
}

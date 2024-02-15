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
                row.CreateCells(clientsDataGridView);

                row.Cells[0].Value = client.Id;
                row.Cells[1].Value = client.SurName;
                row.Cells[2].Value = client.FullName;

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
            Form clientForm = new ClientForm(clientsDataGridView.SelectedCells[0].OwningRow);
            clientForm.ShowDialog();
        }
    }
}

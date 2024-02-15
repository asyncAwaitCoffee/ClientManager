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
            List<Client> clients = await DataAccess.GetUserClients();
            foreach (Client client in clients)
            {
                var row = new DataGridViewRow();
                row.CreateCells(clientsDataGridView);

                row.Cells[0].Value = client.Id;
                row.Cells[1].Value = client.SurName;
                row.Cells[2].Value = client.FullName;
                row.Cells[3].Value = client.AccountId;

                clientsDataGridView.Rows.Add(row);
            }
            
        }

        private void clientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(clientsDataGridView.CurrentCell.Value.ToString());
        }
    }
}

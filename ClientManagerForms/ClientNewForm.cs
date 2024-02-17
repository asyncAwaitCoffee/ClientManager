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
    public partial class ClientNewForm : Form
    {
        private BindingList<Client> _clients;
        public ClientNewForm(BindingList<Client> clients)
        {
            InitializeComponent();

            _clients = clients;
        }

        private async void createClientButton_Click(object sender, EventArgs e)
        {
            int gender = int.Parse((string)genderPanel.Controls.OfType<RadioButton>().First(r => r.Checked).Tag);
            // TODO - managerId
            int managerId = Manager.Instance().Id;

            int clientId = await DataAccess.CreateNewClient(surnameTextBox.Text, nameTextBox.Text, gender, managerId);

            if (clientId == -1)
            {
                return;
            }

            _clients.Add(new Client
            {
                Name = surnameTextBox.Text,
                SurName = nameTextBox.Text,
                Gender = gender,
                Id = clientId,
                // TODO - AccountsId
                AccountsId = -1,
            });
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ClientManagerForms
{
    public partial class SuperManagerForm : Form
    {
        BindingList<User> assignedManagers;
        BindingList<User> availableManagers;

        string _username = "";

        List<int> idsToAdd = [];
        List<int> idsToRemove = [];
        public SuperManagerForm()
        {
            InitializeComponent();
        }



        private async void findButton_Click(object sender, EventArgs e)
        {
            // TODO - use global consts
            if (usernameTextBox.Text.Length < 3)
            {
                return;
            }

            if (!await DataAccess.IsUserExists(usernameTextBox.Text))
            {
                MessageBox.Show($"User [ {_username} ] does not exist.");
                return;
            };

            _username = usernameTextBox.Text;

            idsToAdd.Clear();
            idsToRemove.Clear();

            BindingList<User> users = await DataAccess.GetAllUsersForManager(_username);

            assignedForLabel.Text = _username;

            assignedManagers = new BindingList<User>(users.Where(u => u.ManagedId != 0).ToList());
            availableManagers = new BindingList<User>(users.Where(u => u.ManagedId == 0).ToList());

            assignedManagersListBox.DataSource = assignedManagers;
            assignedManagersListBox.DisplayMember = "UserName";

            availableManagerListBox.DataSource = availableManagers;
            availableManagerListBox.DisplayMember = "UserName";
        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            User availableManager = (User)availableManagerListBox.SelectedItem;

            if (availableManagers.Remove(availableManager))
            {
                assignedManagers.Add(availableManager);

                idsToRemove.Remove(availableManager.Id);
                idsToAdd.Add(availableManager.Id);                
            }

        }

        private void removeManagerButton_Click(object sender, EventArgs e)
        {
            User assignedManager = (User)assignedManagersListBox.SelectedItem;

            if (assignedManagers.Remove(assignedManager))
            {
                availableManagers.Add(assignedManager);

                idsToAdd.Remove(assignedManager.Id);
                idsToRemove.Add(assignedManager.Id);
            }

        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            // TODO - length as global variable
            if (_username.Length < 3)
            {
                return;
            }

            await DataAccess.AssignManagers(_username, idsToAdd, idsToRemove);
        }
    }
}

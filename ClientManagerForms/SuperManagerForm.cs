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
    public partial class SuperManagerForm : Form
    {
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
            string username = usernameTextBox.Text;
            
            List<User> users = await DataAccess.GetAllUsersForManager(username);

            assignedForLabel.Text = username;

            var groupedUserd = users.GroupBy(u => u.ManagedId > 0);



            superManagerListBox.DataSource = users.Where(u => u.ManagedId > 0).ToList();
            superManagerListBox.DisplayMember = "UserName";

            managerListBox.DataSource = users.Where(u => u.ManagedId == 0).ToList();
            managerListBox.DisplayMember = "UserName";
        }
    }
}

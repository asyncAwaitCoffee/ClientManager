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
    public partial class UsersForm : Form
    {
        BindingList<User> _users;
        public UsersForm()
        {
            InitializeComponent();

            LoadData();
        }

        private async void LoadData()
        {
            _users = await DataAccess.GetAllUsers();

            usersDataGridView.DataSource = _users;
        }
    }
}

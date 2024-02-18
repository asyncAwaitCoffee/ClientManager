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
        List<User> _users;
        public UsersForm()
        {
            InitializeComponent();

            LoadData();
        }

        private async void LoadData()
        {
            _users = await DataAccess.GetAllUsers();

            foreach (User user in _users)
            {
                var row = new DataGridViewRow();
                row.Height = 50;
                row.CreateCells(usersDataGridView);

                row.Cells[0].Value = user.UserName;
                
                //row.Cells[1] = user.PermissionLevel;

                usersDataGridView.Rows.Add(row);

            }
        }
    }
}

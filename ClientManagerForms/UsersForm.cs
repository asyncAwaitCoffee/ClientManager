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
        Dictionary<string, int> _usersToChange = new Dictionary<string, int>();
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
                if (user.PermissionLevel == 9)
                {
                    continue;
                }
                var row = new DataGridViewRow();
                row.Height = 50;
                row.CreateCells(usersDataGridView);

                row.Cells[0].Value = user.UserName;
                row.Cells[1].Value = $"{user.PermissionLevel}";

                usersDataGridView.Rows.Add(row);

            }
        }

        private void usersDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dg)
            {
                _usersToChange[$"{dg.Rows[e.RowIndex].Cells[0].Value}"] = int.Parse((string)dg.Rows[e.RowIndex].Cells[1].Value);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var user in _usersToChange)
            {
                MessageBox.Show($"{user.Key} - {user.Value}");
                DataAccess.UpdateUserPermissionsLevel(user.Key, user.Value);
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

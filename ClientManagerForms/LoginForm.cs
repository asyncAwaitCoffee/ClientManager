using ClientManagerLibrary;
using ClientManagerLibrary.DataAccess;

namespace ClientManagerForms
{
    public partial class LoginForm : Form
    {
        // TODO - logout
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length < 3)
            {
                return;
            }

            (int? userId, int? permissionsLevel) = await DataAccess.TryUserLogin(userNameTextBox.Text, passwordTextBox.Text);

            if (userId == null || permissionsLevel == null)
            {
                return;
            }

            userNameTextBox.Text = "";
            passwordTextBox.Text = "";

            logoutButton.Visible = true;
            loginButton.Visible = false;
            registerButton.Visible = false;

            Manager manager = Manager.Instance();
            manager.UserId = (int)userId;
            manager.PermissionsLevel = (int)permissionsLevel;

            Form clientsForm = new ClientsForm();
            clientsForm.ShowDialog();

        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            // TODO - more meaningful error messages
            loginInfoLabel.Text = "";

            if (await DataAccess.ValidateUserRegistration(userNameTextBox.Text, passwordTextBox.Text))
            {
                DataAccess.SaveUserToDB(userNameTextBox.Text, passwordTextBox.Text);
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                loginInfoLabel.ForeColor = Color.Green;
                loginInfoLabel.Text = "Nice!";
            }
            else
            {
                loginInfoLabel.ForeColor = Color.Red;
                loginInfoLabel.Text = "Err, oh no!";
            }

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            // also the KeyPreview option is set to true
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Manager.Instance().Logout();

            logoutButton.Visible = false;
            loginButton.Visible = true;
            registerButton.Visible = true;
        }
    }
}

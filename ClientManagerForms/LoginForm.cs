using ClientManagerLibrary;
using ClientManagerLibrary.DataAccess;

namespace ClientManagerForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length < 3)
            {
                return;
            }

            int? userId = await DataAccess.TryUserLogin(loginTextBox.Text, passwordTextBox.Text);
            
            if (userId == null)
            {
                return;
            }            
            
            loginTextBox.Text = "";
            passwordTextBox.Text = "";

            Manager manager = Manager.Instance();
            manager.UserId = (int)userId;

            Form clientsForm = new ClientsForm();
            clientsForm.ShowDialog();
            
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            // TODO - more meaningful error messages
            loginInfoLabel.Text = "";

            if (await DataAccess.ValidateUserRegistration(loginTextBox.Text, passwordTextBox.Text))
            {
                DataAccess.SaveUserToDB(loginTextBox.Text, passwordTextBox.Text);
                loginTextBox.Text = "";
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
    }
}

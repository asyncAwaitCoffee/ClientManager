using ClientManagerLibrary.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            if (loginTextBox.Text.Length > 0 && await DataAccess.TryUserLogin(loginTextBox.Text, passwordTextBox.Text))
            {
                this.Close();
            }
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
    }
}

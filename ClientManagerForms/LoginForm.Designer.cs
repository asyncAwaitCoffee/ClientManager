namespace ClientManagerForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            userNameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerButton = new Button();
            loginInfoLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            logoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.White;
            userNameTextBox.Location = new Point(56, 80);
            userNameTextBox.Margin = new Padding(6, 6, 6, 6);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(246, 39);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(56, 178);
            passwordTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(246, 39);
            passwordTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(56, 41);
            userNameLabel.Margin = new Padding(2, 0, 2, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(133, 32);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "User name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = SystemColors.ControlText;
            passwordLabel.Location = new Point(56, 144);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 32);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(46, 262);
            loginButton.Margin = new Padding(2, 2, 2, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(127, 43);
            loginButton.TabIndex = 4;
            loginButton.Text = "&Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(183, 262);
            registerButton.Margin = new Padding(2, 2, 2, 2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(127, 43);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginInfoLabel
            // 
            loginInfoLabel.AutoSize = true;
            loginInfoLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginInfoLabel.ForeColor = Color.Red;
            loginInfoLabel.Location = new Point(56, 17);
            loginInfoLabel.Margin = new Padding(2, 0, 2, 0);
            loginInfoLabel.Name = "loginInfoLabel";
            loginInfoLabel.Size = new Size(0, 25);
            loginInfoLabel.TabIndex = 6;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(114, 262);
            logoutButton.Margin = new Padding(2, 2, 2, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(127, 43);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Visible = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(356, 358);
            Controls.Add(logoutButton);
            Controls.Add(loginInfoLabel);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            Margin = new Padding(6, 6, 6, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyDown += LoginForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Label userNameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button registerButton;
        private Label loginInfoLabel;
        private ErrorProvider errorProvider1;
        private Button logoutButton;
    }
}

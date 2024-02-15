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
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerButton = new Button();
            loginInfoLabel = new Label();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.BackColor = Color.White;
            loginTextBox.Location = new Point(77, 112);
            loginTextBox.Margin = new Padding(8, 9, 8, 9);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(339, 50);
            loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(77, 250);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(339, 50);
            passwordTextBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(77, 58);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(106, 45);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Login:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = SystemColors.ControlText;
            passwordLabel.Location = new Point(77, 202);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(153, 45);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(63, 369);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(176, 61);
            loginButton.TabIndex = 4;
            loginButton.Text = "&Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(254, 369);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(176, 61);
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
            loginInfoLabel.Location = new Point(77, 24);
            loginInfoLabel.Name = "loginInfoLabel";
            loginInfoLabel.Size = new Size(0, 25);
            loginInfoLabel.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(493, 504);
            Controls.Add(loginInfoLabel);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(loginLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            KeyPreview = true;
            Margin = new Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            KeyDown += LoginForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label loginLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button registerButton;
        private Label loginInfoLabel;
    }
}

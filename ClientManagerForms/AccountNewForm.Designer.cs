namespace ClientManagerForms
{
    partial class AccountNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clientFullNameTextBox = new TextBox();
            newAccountCodeTextBox = new TextBox();
            createAccountButton = new Button();
            clientLabel = new Label();
            accountCodeLabel = new Label();
            accountCodeErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)accountCodeErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // clientFullNameTextBox
            // 
            clientFullNameTextBox.Location = new Point(22, 52);
            clientFullNameTextBox.Name = "clientFullNameTextBox";
            clientFullNameTextBox.ReadOnly = true;
            clientFullNameTextBox.Size = new Size(288, 35);
            clientFullNameTextBox.TabIndex = 0;
            // 
            // newAccountCodeTextBox
            // 
            newAccountCodeTextBox.Location = new Point(22, 135);
            newAccountCodeTextBox.MaxLength = 10;
            newAccountCodeTextBox.Name = "newAccountCodeTextBox";
            newAccountCodeTextBox.Size = new Size(255, 35);
            newAccountCodeTextBox.TabIndex = 1;
            newAccountCodeTextBox.Validating += newAccountCodeTextBox_Validating;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(88, 199);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(156, 50);
            createAccountButton.TabIndex = 2;
            createAccountButton.Text = "Create";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.Location = new Point(22, 19);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(71, 30);
            clientLabel.TabIndex = 3;
            clientLabel.Text = "Client:";
            // 
            // accountCodeLabel
            // 
            accountCodeLabel.AutoSize = true;
            accountCodeLabel.Location = new Point(22, 102);
            accountCodeLabel.Name = "accountCodeLabel";
            accountCodeLabel.Size = new Size(146, 30);
            accountCodeLabel.TabIndex = 4;
            accountCodeLabel.Text = "Account code:";
            // 
            // accountCodeErrorProvider
            // 
            accountCodeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            accountCodeErrorProvider.ContainerControl = this;
            // 
            // AccountNewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(333, 280);
            Controls.Add(accountCodeLabel);
            Controls.Add(clientLabel);
            Controls.Add(createAccountButton);
            Controls.Add(newAccountCodeTextBox);
            Controls.Add(clientFullNameTextBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            Name = "AccountNewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Account";
            ((System.ComponentModel.ISupportInitialize)accountCodeErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientFullNameTextBox;
        private TextBox newAccountCodeTextBox;
        private Button createAccountButton;
        private Label clientLabel;
        private Label accountCodeLabel;
        private ErrorProvider accountCodeErrorProvider;
    }
}
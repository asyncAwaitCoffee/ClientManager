namespace ClientManagerForms
{
    partial class ClientEditForm
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
            clientNameTextBox = new TextBox();
            clientAccountsIdscomboBox = new ComboBox();
            saveClientButton = new Button();
            cancelButton = new Button();
            clientSurnameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            addNewAccountLinkLabel = new LinkLabel();
            accountsGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            accountsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // clientNameTextBox
            // 
            clientNameTextBox.Location = new Point(19, 111);
            clientNameTextBox.Name = "clientNameTextBox";
            clientNameTextBox.PlaceholderText = "Name";
            clientNameTextBox.Size = new Size(408, 43);
            clientNameTextBox.TabIndex = 0;
            // 
            // clientAccountsIdscomboBox
            // 
            clientAccountsIdscomboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientAccountsIdscomboBox.FormattingEnabled = true;
            clientAccountsIdscomboBox.Location = new Point(30, 63);
            clientAccountsIdscomboBox.Name = "clientAccountsIdscomboBox";
            clientAccountsIdscomboBox.Size = new Size(220, 40);
            clientAccountsIdscomboBox.TabIndex = 1;
            clientAccountsIdscomboBox.SelectedIndexChanged += clientAccountsIdscomboBox_SelectedIndexChanged;
            // 
            // saveClientButton
            // 
            saveClientButton.Enabled = false;
            saveClientButton.Location = new Point(48, 386);
            saveClientButton.Name = "saveClientButton";
            saveClientButton.Size = new Size(147, 69);
            saveClientButton.TabIndex = 2;
            saveClientButton.Text = "Save";
            saveClientButton.UseVisualStyleBackColor = true;
            saveClientButton.Click += saveClientButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(276, 386);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(147, 69);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // clientSurnameTextBox
            // 
            clientSurnameTextBox.Location = new Point(19, 44);
            clientSurnameTextBox.Name = "clientSurnameTextBox";
            clientSurnameTextBox.PlaceholderText = "Surname";
            clientSurnameTextBox.Size = new Size(408, 43);
            clientSurnameTextBox.TabIndex = 4;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceTextBox.Location = new Point(269, 63);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.ReadOnly = true;
            balanceTextBox.Size = new Size(147, 39);
            balanceTextBox.TabIndex = 5;
            // 
            // addNewAccountLinkLabel
            // 
            addNewAccountLinkLabel.AutoSize = true;
            addNewAccountLinkLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addNewAccountLinkLabel.Location = new Point(30, 106);
            addNewAccountLinkLabel.Name = "addNewAccountLinkLabel";
            addNewAccountLinkLabel.Size = new Size(95, 30);
            addNewAccountLinkLabel.TabIndex = 8;
            addNewAccountLinkLabel.TabStop = true;
            addNewAccountLinkLabel.Text = "Add new";
            addNewAccountLinkLabel.LinkClicked += addNewAccountLinkLabel_LinkClicked;
            // 
            // accountsGroupBox
            // 
            accountsGroupBox.Controls.Add(clientAccountsIdscomboBox);
            accountsGroupBox.Controls.Add(addNewAccountLinkLabel);
            accountsGroupBox.Controls.Add(balanceTextBox);
            accountsGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            accountsGroupBox.Location = new Point(12, 208);
            accountsGroupBox.Name = "accountsGroupBox";
            accountsGroupBox.Size = new Size(447, 146);
            accountsGroupBox.TabIndex = 9;
            accountsGroupBox.TabStop = false;
            accountsGroupBox.Text = "Accounts:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clientSurnameTextBox);
            groupBox1.Controls.Add(clientNameTextBox);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 190);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client info:";
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 488);
            Controls.Add(groupBox1);
            Controls.Add(accountsGroupBox);
            Controls.Add(cancelButton);
            Controls.Add(saveClientButton);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8, 9, 8, 9);
            Name = "ClientEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Client Edit";
            accountsGroupBox.ResumeLayout(false);
            accountsGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox clientNameTextBox;
        private ComboBox clientAccountsIdscomboBox;
        private Button saveClientButton;
        private Button cancelButton;
        private TextBox clientSurnameTextBox;
        private TextBox balanceTextBox;
        private LinkLabel addNewAccountLinkLabel;
        private GroupBox accountsGroupBox;
        private GroupBox groupBox1;
    }
}
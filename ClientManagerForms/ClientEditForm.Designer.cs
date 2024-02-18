﻿namespace ClientManagerForms
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
            clientFullNameTextBox = new TextBox();
            clientAccountsIdscomboBox = new ComboBox();
            saveClientButton = new Button();
            cancelButton = new Button();
            clientSurnameTextBox = new TextBox();
            balanceTextBox = new TextBox();
            newClientLabel = new Label();
            accountLabel = new Label();
            SuspendLayout();
            // 
            // clientFullNameTextBox
            // 
            clientFullNameTextBox.Location = new Point(36, 142);
            clientFullNameTextBox.Name = "clientFullNameTextBox";
            clientFullNameTextBox.PlaceholderText = "Name";
            clientFullNameTextBox.Size = new Size(386, 50);
            clientFullNameTextBox.TabIndex = 0;
            // 
            // clientAccountsIdscomboBox
            // 
            clientAccountsIdscomboBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clientAccountsIdscomboBox.FormattingEnabled = true;
            clientAccountsIdscomboBox.Location = new Point(36, 242);
            clientAccountsIdscomboBox.Name = "clientAccountsIdscomboBox";
            clientAccountsIdscomboBox.Size = new Size(220, 40);
            clientAccountsIdscomboBox.TabIndex = 1;
            clientAccountsIdscomboBox.SelectedIndexChanged += clientAccountsIdscomboBox_SelectedIndexChanged;
            // 
            // saveClientButton
            // 
            saveClientButton.Enabled = false;
            saveClientButton.Location = new Point(36, 326);
            saveClientButton.Name = "saveClientButton";
            saveClientButton.Size = new Size(147, 69);
            saveClientButton.TabIndex = 2;
            saveClientButton.Text = "Save";
            saveClientButton.UseVisualStyleBackColor = true;
            saveClientButton.Click += saveClientButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(275, 326);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(147, 69);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // clientSurnameTextBox
            // 
            clientSurnameTextBox.Location = new Point(36, 75);
            clientSurnameTextBox.Name = "clientSurnameTextBox";
            clientSurnameTextBox.PlaceholderText = "Surname";
            clientSurnameTextBox.Size = new Size(386, 50);
            clientSurnameTextBox.TabIndex = 4;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            balanceTextBox.Location = new Point(275, 242);
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.ReadOnly = true;
            balanceTextBox.Size = new Size(147, 39);
            balanceTextBox.TabIndex = 5;
            // 
            // newClientLabel
            // 
            newClientLabel.AutoSize = true;
            newClientLabel.Location = new Point(12, 9);
            newClientLabel.Name = "newClientLabel";
            newClientLabel.Size = new Size(173, 45);
            newClientLabel.TabIndex = 6;
            newClientLabel.Text = "Client info:";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            accountLabel.Location = new Point(36, 207);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(116, 32);
            accountLabel.TabIndex = 7;
            accountLabel.Text = "Accounts:";
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(471, 433);
            Controls.Add(accountLabel);
            Controls.Add(newClientLabel);
            Controls.Add(balanceTextBox);
            Controls.Add(clientSurnameTextBox);
            Controls.Add(cancelButton);
            Controls.Add(saveClientButton);
            Controls.Add(clientAccountsIdscomboBox);
            Controls.Add(clientFullNameTextBox);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(8, 9, 8, 9);
            Name = "ClientEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientFullNameTextBox;
        private ComboBox clientAccountsIdscomboBox;
        private Button saveClientButton;
        private Button cancelButton;
        private TextBox clientSurnameTextBox;
        private TextBox balanceTextBox;
        private Label newClientLabel;
        private Label accountLabel;
    }
}
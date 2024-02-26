namespace ClientManagerForms
{
    partial class ClientNewForm
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
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            newClientInfoLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            genderPanel = new Panel();
            createClientButton = new Button();
            genderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // surnameTextBox
            // 
            surnameTextBox.Font = new Font("Segoe UI", 15.75F);
            surnameTextBox.Location = new Point(31, 87);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(298, 35);
            surnameTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 15.75F);
            nameTextBox.Location = new Point(31, 166);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(298, 35);
            nameTextBox.TabIndex = 1;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Segoe UI", 15.75F);
            surnameLabel.Location = new Point(31, 52);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(95, 30);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 15.75F);
            nameLabel.Location = new Point(31, 131);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(69, 30);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // newClientInfoLabel
            // 
            newClientInfoLabel.AutoSize = true;
            newClientInfoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newClientInfoLabel.Location = new Point(12, 9);
            newClientInfoLabel.Name = "newClientInfoLabel";
            newClientInfoLabel.Size = new Size(213, 32);
            newClientInfoLabel.TabIndex = 6;
            newClientInfoLabel.Text = "Client information:";
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Checked = true;
            maleRadioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maleRadioButton.Location = new Point(5, 3);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(72, 29);
            maleRadioButton.TabIndex = 7;
            maleRadioButton.TabStop = true;
            maleRadioButton.Tag = "1";
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            femaleRadioButton.Location = new Point(83, 3);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(90, 29);
            femaleRadioButton.TabIndex = 8;
            femaleRadioButton.Tag = "0";
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(maleRadioButton);
            genderPanel.Controls.Add(femaleRadioButton);
            genderPanel.Location = new Point(84, 220);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(180, 38);
            genderPanel.TabIndex = 9;
            // 
            // createClientButton
            // 
            createClientButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createClientButton.Location = new Point(108, 282);
            createClientButton.Name = "createClientButton";
            createClientButton.Size = new Size(128, 41);
            createClientButton.TabIndex = 10;
            createClientButton.Text = "Create";
            createClientButton.UseVisualStyleBackColor = true;
            createClientButton.Click += createClientButton_Click;
            // 
            // ClientNewForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 341);
            Controls.Add(createClientButton);
            Controls.Add(genderPanel);
            Controls.Add(newClientInfoLabel);
            Controls.Add(nameLabel);
            Controls.Add(surnameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(surnameTextBox);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "ClientNewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Client";
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private Label surnameLabel;
        private Label nameLabel;
        private Label newClientInfoLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Panel genderPanel;
        private Button createClientButton;
    }
}
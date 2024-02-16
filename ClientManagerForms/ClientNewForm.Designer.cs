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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            surnameLabel = new Label();
            nameLabel = new Label();
            newClientInfoLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            panel1 = new Panel();
            createClientButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 39);
            textBox2.TabIndex = 1;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(48, 61);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(109, 32);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "Surname";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(48, 140);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(78, 32);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            // 
            // newClientInfoLabel
            // 
            newClientInfoLabel.AutoSize = true;
            newClientInfoLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            newClientInfoLabel.Location = new Point(12, 9);
            newClientInfoLabel.Name = "newClientInfoLabel";
            newClientInfoLabel.Size = new Size(253, 40);
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
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(maleRadioButton);
            panel1.Controls.Add(femaleRadioButton);
            panel1.Location = new Point(92, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 38);
            panel1.TabIndex = 9;
            // 
            // createClientButton
            // 
            createClientButton.Location = new Point(117, 292);
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
            ClientSize = new Size(394, 358);
            Controls.Add(createClientButton);
            Controls.Add(panel1);
            Controls.Add(newClientInfoLabel);
            Controls.Add(nameLabel);
            Controls.Add(surnameLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "ClientNewForm";
            Text = "New Client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label surnameLabel;
        private Label nameLabel;
        private Label newClientInfoLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Panel panel1;
        private Button createClientButton;
    }
}
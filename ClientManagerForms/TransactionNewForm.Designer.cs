namespace ClientManagerForms
{
    partial class TransactionNewForm
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
            accountFromTextBox = new TextBox();
            accountFromButton = new Button();
            clientFromTextBox = new TextBox();
            clientToTextBox = new TextBox();
            accountToButton = new Button();
            accountToTextBox = new TextBox();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            isImidiateCheckBox = new CheckBox();
            createButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // accountFromTextBox
            // 
            accountFromTextBox.Location = new Point(11, 46);
            accountFromTextBox.Name = "accountFromTextBox";
            accountFromTextBox.Size = new Size(195, 35);
            accountFromTextBox.TabIndex = 0;
            // 
            // accountFromButton
            // 
            accountFromButton.Location = new Point(11, 89);
            accountFromButton.Name = "accountFromButton";
            accountFromButton.Size = new Size(159, 40);
            accountFromButton.TabIndex = 1;
            accountFromButton.Text = "Apply";
            accountFromButton.UseVisualStyleBackColor = true;
            accountFromButton.Click += accountFromButton_Click;
            // 
            // clientFromTextBox
            // 
            clientFromTextBox.Location = new Point(11, 137);
            clientFromTextBox.Name = "clientFromTextBox";
            clientFromTextBox.ReadOnly = true;
            clientFromTextBox.Size = new Size(427, 35);
            clientFromTextBox.TabIndex = 3;
            // 
            // clientToTextBox
            // 
            clientToTextBox.Location = new Point(11, 135);
            clientToTextBox.Name = "clientToTextBox";
            clientToTextBox.ReadOnly = true;
            clientToTextBox.Size = new Size(427, 35);
            clientToTextBox.TabIndex = 7;
            // 
            // accountToButton
            // 
            accountToButton.Location = new Point(11, 89);
            accountToButton.Name = "accountToButton";
            accountToButton.Size = new Size(159, 40);
            accountToButton.TabIndex = 5;
            accountToButton.Text = "Apply";
            accountToButton.UseVisualStyleBackColor = true;
            accountToButton.Click += accountToButton_Click;
            // 
            // accountToTextBox
            // 
            accountToTextBox.Location = new Point(11, 48);
            accountToTextBox.Name = "accountToTextBox";
            accountToTextBox.Size = new Size(195, 35);
            accountToTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(117, 476);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(328, 35);
            amountTextBox.TabIndex = 8;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(12, 479);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(93, 30);
            amountLabel.TabIndex = 10;
            amountLabel.Text = "Amount:";
            // 
            // isImidiateCheckBox
            // 
            isImidiateCheckBox.AutoSize = true;
            isImidiateCheckBox.Location = new Point(117, 517);
            isImidiateCheckBox.Name = "isImidiateCheckBox";
            isImidiateCheckBox.Size = new Size(216, 34);
            isImidiateCheckBox.TabIndex = 11;
            isImidiateCheckBox.Text = "Imidiate transaction";
            isImidiateCheckBox.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Location = new Point(157, 568);
            createButton.Name = "createButton";
            createButton.Size = new Size(159, 40);
            createButton.TabIndex = 12;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(accountFromTextBox);
            groupBox1.Controls.Add(accountFromButton);
            groupBox1.Controls.Add(clientFromTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 218);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Account from:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(accountToTextBox);
            groupBox2.Controls.Add(accountToButton);
            groupBox2.Controls.Add(clientToTextBox);
            groupBox2.Location = new Point(12, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 218);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Account to:";
            // 
            // TransactionNewForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(473, 635);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(createButton);
            Controls.Add(isImidiateCheckBox);
            Controls.Add(amountLabel);
            Controls.Add(amountTextBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TransactionNewForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Transaction";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox accountFromTextBox;
        private Button accountFromButton;
        private TextBox clientFromTextBox;
        private TextBox clientToTextBox;
        private Button accountToButton;
        private TextBox accountToTextBox;
        private TextBox amountTextBox;
        private Label amountLabel;
        private CheckBox isImidiateCheckBox;
        private Button createButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
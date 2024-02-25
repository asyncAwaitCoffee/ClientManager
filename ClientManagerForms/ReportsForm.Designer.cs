namespace ClientManagerForms
{
    partial class ReportsForm
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
            clientByAccountTextBox = new TextBox();
            accountsCheckedListBox = new CheckedListBox();
            buildReportButton = new Button();
            clientByAccountLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // clientByAccountTextBox
            // 
            clientByAccountTextBox.Location = new Point(35, 49);
            clientByAccountTextBox.Name = "clientByAccountTextBox";
            clientByAccountTextBox.Size = new Size(179, 35);
            clientByAccountTextBox.TabIndex = 0;
            // 
            // accountsCheckedListBox
            // 
            accountsCheckedListBox.CheckOnClick = true;
            accountsCheckedListBox.FormattingEnabled = true;
            accountsCheckedListBox.Location = new Point(35, 108);
            accountsCheckedListBox.Name = "accountsCheckedListBox";
            accountsCheckedListBox.Size = new Size(232, 214);
            accountsCheckedListBox.TabIndex = 1;
            // 
            // buildReportButton
            // 
            buildReportButton.Location = new Point(92, 364);
            buildReportButton.Name = "buildReportButton";
            buildReportButton.Size = new Size(118, 49);
            buildReportButton.TabIndex = 2;
            buildReportButton.Text = "Build";
            buildReportButton.UseVisualStyleBackColor = true;
            buildReportButton.Click += buildReportButton_Click;
            // 
            // clientByAccountLabel
            // 
            clientByAccountLabel.AutoSize = true;
            clientByAccountLabel.Location = new Point(35, 16);
            clientByAccountLabel.Name = "clientByAccountLabel";
            clientByAccountLabel.Size = new Size(179, 30);
            clientByAccountLabel.TabIndex = 3;
            clientByAccountLabel.Text = "Client by account:";
            // 
            // okButton
            // 
            okButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            okButton.Location = new Point(220, 49);
            okButton.Name = "okButton";
            okButton.Size = new Size(47, 35);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(302, 445);
            Controls.Add(okButton);
            Controls.Add(clientByAccountLabel);
            Controls.Add(buildReportButton);
            Controls.Add(accountsCheckedListBox);
            Controls.Add(clientByAccountTextBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reports Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientByAccountTextBox;
        private CheckedListBox accountsCheckedListBox;
        private Button buildReportButton;
        private Label clientByAccountLabel;
        private Button okButton;
    }
}
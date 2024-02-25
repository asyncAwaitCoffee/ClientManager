namespace ClientManagerForms
{
    partial class SuperManagerForm
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
            assignedManagersListBox = new ListBox();
            availableManagerListBox = new ListBox();
            removeManagerButton = new Button();
            addManagerButton = new Button();
            saveButton = new Button();
            usernameTextBox = new TextBox();
            findButton = new Button();
            assignedLabel = new Label();
            label1 = new Label();
            assignedForLabel = new Label();
            SuspendLayout();
            // 
            // assignedManagersListBox
            // 
            assignedManagersListBox.FormattingEnabled = true;
            assignedManagersListBox.ItemHeight = 30;
            assignedManagersListBox.Location = new Point(21, 115);
            assignedManagersListBox.Name = "assignedManagersListBox";
            assignedManagersListBox.Size = new Size(218, 304);
            assignedManagersListBox.TabIndex = 0;
            // 
            // availableManagerListBox
            // 
            availableManagerListBox.FormattingEnabled = true;
            availableManagerListBox.ItemHeight = 30;
            availableManagerListBox.Location = new Point(316, 115);
            availableManagerListBox.Name = "availableManagerListBox";
            availableManagerListBox.Size = new Size(218, 304);
            availableManagerListBox.TabIndex = 1;
            // 
            // removeManagerButton
            // 
            removeManagerButton.Location = new Point(245, 144);
            removeManagerButton.Name = "removeManagerButton";
            removeManagerButton.Size = new Size(65, 45);
            removeManagerButton.TabIndex = 2;
            removeManagerButton.Text = ">>";
            removeManagerButton.UseVisualStyleBackColor = true;
            removeManagerButton.Click += removeManagerButton_Click;
            // 
            // addManagerButton
            // 
            addManagerButton.Location = new Point(245, 195);
            addManagerButton.Name = "addManagerButton";
            addManagerButton.Size = new Size(65, 45);
            addManagerButton.TabIndex = 3;
            addManagerButton.Text = "<<";
            addManagerButton.UseVisualStyleBackColor = true;
            addManagerButton.Click += addManagerButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(188, 456);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(190, 54);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(21, 23);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(218, 35);
            usernameTextBox.TabIndex = 5;
            // 
            // findButton
            // 
            findButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            findButton.Location = new Point(245, 23);
            findButton.Name = "findButton";
            findButton.Size = new Size(65, 35);
            findButton.TabIndex = 6;
            findButton.Text = "Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // assignedLabel
            // 
            assignedLabel.AutoSize = true;
            assignedLabel.Location = new Point(21, 82);
            assignedLabel.Name = "assignedLabel";
            assignedLabel.Size = new Size(134, 30);
            assignedLabel.TabIndex = 7;
            assignedLabel.Text = "Assigned for:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 82);
            label1.Name = "label1";
            label1.Size = new Size(191, 30);
            label1.TabIndex = 8;
            label1.Text = "Available to assign:";
            // 
            // assignedForLabel
            // 
            assignedForLabel.AutoSize = true;
            assignedForLabel.Location = new Point(150, 82);
            assignedForLabel.Name = "assignedForLabel";
            assignedForLabel.Size = new Size(41, 30);
            assignedForLabel.TabIndex = 9;
            assignedForLabel.Text = "<>";
            // 
            // SuperManagerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 535);
            Controls.Add(assignedForLabel);
            Controls.Add(label1);
            Controls.Add(assignedLabel);
            Controls.Add(findButton);
            Controls.Add(usernameTextBox);
            Controls.Add(saveButton);
            Controls.Add(addManagerButton);
            Controls.Add(removeManagerButton);
            Controls.Add(availableManagerListBox);
            Controls.Add(assignedManagersListBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SuperManagerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Super Manager Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox assignedManagersListBox;
        private ListBox availableManagerListBox;
        private Button removeManagerButton;
        private Button addManagerButton;
        private Button saveButton;
        private TextBox usernameTextBox;
        private Button findButton;
        private Label assignedLabel;
        private Label label1;
        private Label assignedForLabel;
    }
}
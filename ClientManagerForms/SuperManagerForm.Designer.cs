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
            superManagerListBox = new ListBox();
            managerListBox = new ListBox();
            addButton = new Button();
            button2 = new Button();
            saveButton = new Button();
            usernameTextBox = new TextBox();
            findButton = new Button();
            assignedLabel = new Label();
            label1 = new Label();
            assignedForLabel = new Label();
            SuspendLayout();
            // 
            // superManagerListBox
            // 
            superManagerListBox.FormattingEnabled = true;
            superManagerListBox.ItemHeight = 30;
            superManagerListBox.Location = new Point(21, 115);
            superManagerListBox.Name = "superManagerListBox";
            superManagerListBox.Size = new Size(218, 304);
            superManagerListBox.TabIndex = 0;
            // 
            // managerListBox
            // 
            managerListBox.FormattingEnabled = true;
            managerListBox.ItemHeight = 30;
            managerListBox.Location = new Point(316, 115);
            managerListBox.Name = "managerListBox";
            managerListBox.Size = new Size(218, 304);
            managerListBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(245, 144);
            addButton.Name = "addButton";
            addButton.Size = new Size(65, 45);
            addButton.TabIndex = 2;
            addButton.Text = ">>";
            addButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(245, 195);
            button2.Name = "button2";
            button2.Size = new Size(65, 45);
            button2.TabIndex = 3;
            button2.Text = "<<";
            button2.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(188, 456);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(190, 54);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
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
            Controls.Add(button2);
            Controls.Add(addButton);
            Controls.Add(managerListBox);
            Controls.Add(superManagerListBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SuperManagerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Super Manager Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox superManagerListBox;
        private ListBox managerListBox;
        private Button addButton;
        private Button button2;
        private Button saveButton;
        private TextBox usernameTextBox;
        private Button findButton;
        private Label assignedLabel;
        private Label label1;
        private Label assignedForLabel;
    }
}
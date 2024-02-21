namespace ClientManagerForms
{
    partial class UsersForm
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
            usersDataGridView = new DataGridView();
            userNameColumn = new DataGridViewTextBoxColumn();
            permissionColumn = new DataGridViewComboBoxColumn();
            userBindingSource = new BindingSource(components);
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Columns.AddRange(new DataGridViewColumn[] { userNameColumn, permissionColumn });
            usersDataGridView.Location = new Point(12, 36);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.Size = new Size(263, 324);
            usersDataGridView.TabIndex = 0;
            usersDataGridView.CellEndEdit += usersDataGridView_CellEndEdit;
            // 
            // userNameColumn
            // 
            userNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userNameColumn.HeaderText = "User";
            userNameColumn.Name = "userNameColumn";
            userNameColumn.Width = 86;
            // 
            // permissionColumn
            // 
            permissionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            permissionColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            permissionColumn.HeaderText = "Permission";
            permissionColumn.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            permissionColumn.Name = "permissionColumn";
            permissionColumn.Width = 134;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(ClientManagerLibrary.Models.User);
            // 
            // saveButton
            // 
            saveButton.Location = new Point(291, 60);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(129, 39);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(291, 115);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(129, 39);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(435, 376);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(usersDataGridView);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView usersDataGridView;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewComboBoxColumn permissionColumn;
        private Button saveButton;
        private Button cancelButton;
    }
}
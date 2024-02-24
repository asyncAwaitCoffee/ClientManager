namespace ClientManagerForms
{
    partial class TransactionsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            transactionsDataGridView = new DataGridView();
            clientFromColumn = new DataGridViewTextBoxColumn();
            clientToColumn = new DataGridViewTextBoxColumn();
            accountFromColumn = new DataGridViewTextBoxColumn();
            accountToColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            creationDTColumn = new DataGridViewTextBoxColumn();
            transferDTColumn = new DataGridViewTextBoxColumn();
            conductButton = new Button();
            fromAccountFilterTextBox = new TextBox();
            toAccountFilterTextBox = new TextBox();
            accountFilterButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            transactionsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientFromColumn, clientToColumn, accountFromColumn, accountToColumn, amountColumn, creationDTColumn, transferDTColumn });
            transactionsDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            transactionsDataGridView.Location = new Point(10, 48);
            transactionsDataGridView.Name = "transactionsDataGridView";
            dataGridViewCellStyle2.BackColor = Color.Silver;
            transactionsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            transactionsDataGridView.Size = new Size(779, 384);
            transactionsDataGridView.TabIndex = 0;
            // 
            // clientFromColumn
            // 
            clientFromColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientFromColumn.HeaderText = "From client";
            clientFromColumn.Name = "clientFromColumn";
            clientFromColumn.Width = 141;
            // 
            // clientToColumn
            // 
            clientToColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientToColumn.HeaderText = "To client";
            clientToColumn.Name = "clientToColumn";
            clientToColumn.Width = 115;
            // 
            // accountFromColumn
            // 
            accountFromColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountFromColumn.HeaderText = "From account";
            accountFromColumn.Name = "accountFromColumn";
            accountFromColumn.Width = 165;
            // 
            // accountToColumn
            // 
            accountToColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            accountToColumn.HeaderText = "To account";
            accountToColumn.Name = "accountToColumn";
            accountToColumn.Width = 139;
            // 
            // amountColumn
            // 
            amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            amountColumn.HeaderText = "Amount";
            amountColumn.Name = "amountColumn";
            amountColumn.Width = 113;
            // 
            // creationDTColumn
            // 
            creationDTColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            creationDTColumn.HeaderText = "Creation";
            creationDTColumn.Name = "creationDTColumn";
            creationDTColumn.Width = 116;
            // 
            // transferDTColumn
            // 
            transferDTColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transferDTColumn.HeaderText = "Transfer";
            transferDTColumn.Name = "transferDTColumn";
            transferDTColumn.Width = 111;
            // 
            // conductButton
            // 
            conductButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            conductButton.Location = new Point(662, 12);
            conductButton.Name = "conductButton";
            conductButton.Size = new Size(127, 30);
            conductButton.TabIndex = 1;
            conductButton.Text = "Conduct";
            conductButton.UseVisualStyleBackColor = true;
            conductButton.Click += conductButton_Click;
            // 
            // fromAccountFilterTextBox
            // 
            fromAccountFilterTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fromAccountFilterTextBox.Location = new Point(12, 12);
            fromAccountFilterTextBox.Name = "fromAccountFilterTextBox";
            fromAccountFilterTextBox.PlaceholderText = "From account...";
            fromAccountFilterTextBox.Size = new Size(180, 29);
            fromAccountFilterTextBox.TabIndex = 2;
            // 
            // toAccountFilterTextBox
            // 
            toAccountFilterTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAccountFilterTextBox.Location = new Point(198, 12);
            toAccountFilterTextBox.Name = "toAccountFilterTextBox";
            toAccountFilterTextBox.PlaceholderText = "To account...";
            toAccountFilterTextBox.Size = new Size(180, 29);
            toAccountFilterTextBox.TabIndex = 3;
            // 
            // accountFilterButton
            // 
            accountFilterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            accountFilterButton.Location = new Point(384, 12);
            accountFilterButton.Name = "accountFilterButton";
            accountFilterButton.Size = new Size(59, 30);
            accountFilterButton.TabIndex = 4;
            accountFilterButton.Text = "Filter";
            accountFilterButton.UseVisualStyleBackColor = true;
            accountFilterButton.Click += accountFilterButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cancelButton.Location = new Point(449, 12);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(66, 30);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 444);
            Controls.Add(cancelButton);
            Controls.Add(accountFilterButton);
            Controls.Add(toAccountFilterTextBox);
            Controls.Add(fromAccountFilterTextBox);
            Controls.Add(conductButton);
            Controls.Add(transactionsDataGridView);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transactionsDataGridView;
        private Button conductButton;
        private DataGridViewTextBoxColumn clientFromColumn;
        private DataGridViewTextBoxColumn clientToColumn;
        private DataGridViewTextBoxColumn accountFromColumn;
        private DataGridViewTextBoxColumn accountToColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private DataGridViewTextBoxColumn creationDTColumn;
        private DataGridViewTextBoxColumn transferDTColumn;
        private TextBox fromAccountFilterTextBox;
        private TextBox toAccountFilterTextBox;
        private Button accountFilterButton;
        private Button cancelButton;
    }
}
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
            transactionsDataGridView = new DataGridView();
            clientFromColumn = new DataGridViewTextBoxColumn();
            clientToColumn = new DataGridViewTextBoxColumn();
            accountFromColumn = new DataGridViewTextBoxColumn();
            accountToColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            creationDTColumn = new DataGridViewTextBoxColumn();
            transferDTColumn = new DataGridViewTextBoxColumn();
            conductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.AllowUserToAddRows = false;
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientFromColumn, clientToColumn, accountFromColumn, accountToColumn, amountColumn, creationDTColumn, transferDTColumn });
            transactionsDataGridView.Location = new Point(10, 48);
            transactionsDataGridView.Name = "transactionsDataGridView";
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
            accountFromColumn.HeaderText = "From Account";
            accountFromColumn.Name = "accountFromColumn";
            accountFromColumn.Width = 168;
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
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 444);
            Controls.Add(conductButton);
            Controls.Add(transactionsDataGridView);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TransactionsForm";
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView transactionsDataGridView;
        private DataGridViewTextBoxColumn clientFromColumn;
        private DataGridViewTextBoxColumn clientToColumn;
        private DataGridViewTextBoxColumn accountFromColumn;
        private DataGridViewTextBoxColumn accountToColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private DataGridViewTextBoxColumn creationDTColumn;
        private DataGridViewTextBoxColumn transferDTColumn;
        private Button conductButton;
    }
}
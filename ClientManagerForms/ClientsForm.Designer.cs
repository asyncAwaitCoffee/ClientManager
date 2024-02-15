namespace ClientManagerForms
{
    partial class ClientsForm
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
            clientsDataGridView = new DataGridView();
            clientId = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            accountId = new DataGridViewTextBoxColumn();
            checkClientColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.AllowUserToAddRows = false;
            clientsDataGridView.AllowUserToDeleteRows = false;
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientId, surName, fullName, accountId, checkClientColumn });
            clientsDataGridView.Location = new Point(10, 115);
            clientsDataGridView.Margin = new Padding(2);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.ReadOnly = true;
            clientsDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            clientsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            clientsDataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            clientsDataGridView.RowTemplate.Height = 200;
            clientsDataGridView.Size = new Size(699, 279);
            clientsDataGridView.TabIndex = 1;
            clientsDataGridView.CellDoubleClick += clientsDataGridView_CellDoubleClick;
            // 
            // clientId
            // 
            clientId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            clientId.FillWeight = 20F;
            clientId.HeaderText = "Id";
            clientId.Name = "clientId";
            clientId.ReadOnly = true;
            clientId.Width = 65;
            // 
            // surName
            // 
            surName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            surName.FillWeight = 40F;
            surName.HeaderText = "SurName";
            surName.Name = "surName";
            surName.ReadOnly = true;
            surName.Width = 151;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            fullName.FillWeight = 40F;
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            fullName.Width = 162;
            // 
            // accountId
            // 
            accountId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            accountId.FillWeight = 30F;
            accountId.HeaderText = "AccountId";
            accountId.Name = "accountId";
            accountId.ReadOnly = true;
            accountId.Width = 161;
            // 
            // checkClientColumn
            // 
            checkClientColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            checkClientColumn.FillWeight = 20F;
            checkClientColumn.HeaderText = "VIP";
            checkClientColumn.Name = "checkClientColumn";
            checkClientColumn.ReadOnly = true;
            checkClientColumn.Width = 62;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 412);
            Controls.Add(clientsDataGridView);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7);
            Name = "ClientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientsForm";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView clientsDataGridView;
        private ListView clientsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DataGridViewTextBoxColumn clientId;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn accountId;
        private DataGridViewCheckBoxColumn checkClientColumn;
    }
}